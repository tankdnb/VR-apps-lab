#include <EGL/egl.h>
#include <GLES3/gl3.h>
#include <android/log.h>
#include <dlfcn.h>
#include <jni.h>

#include <algorithm>
#include <chrono>
#include <cstring>
#include <fstream>
#include <sstream>
#include <string>
#include <thread>
#include <vector>

#include "third_party/openxr/openxr.h"

namespace
{
constexpr char kLogTag[] = "PicoOpenXrExtensionProbe";
constexpr char kBundledLoaderName[] = "libopenxr_loader.so";
constexpr char kOutputFileName[] = "pico_openxr_extension_probe.txt";

constexpr char kKhrAndroidCreateInstanceExtension[] = "XR_KHR_android_create_instance";
constexpr char kKhrLoaderInitAndroidExtension[] = "XR_KHR_loader_init_android";
constexpr char kKhrOpenGlesEnableExtension[] = "XR_KHR_opengl_es_enable";
constexpr char kPicoCameraImageExtension[] = "XR_PICO_camera_image";
constexpr char kPicoPassthroughExtension[] = "XR_PICO_passthrough";
constexpr char kPicoSecureMixedRealityExtension[] = "XR_PICO_secure_mixed_reality";
constexpr char kPicoExternalCameraExtension[] = "XR_PICO_external_camera";
constexpr char kBdExternalCameraExtension[] = "XR_BD_external_camera";
constexpr char kBdMrManagementExtension[] = "XR_BD_mr_management";
constexpr char kExtFutureExtension[] = "XR_EXT_future";

#ifndef EGL_OPENGL_ES3_BIT_KHR
#define EGL_OPENGL_ES3_BIT_KHR 0x00000040
#endif

typedef struct XrLoaderInitInfoAndroidKHR
{
    XrStructureType             type;
    const void* XR_MAY_ALIAS    next;
    void* XR_MAY_ALIAS          applicationVM;
    void* XR_MAY_ALIAS          applicationContext;
} XrLoaderInitInfoAndroidKHR;

typedef struct XrInstanceCreateInfoAndroidKHR
{
    XrStructureType             type;
    const void* XR_MAY_ALIAS    next;
    void* XR_MAY_ALIAS          applicationVM;
    void* XR_MAY_ALIAS          applicationActivity;
} XrInstanceCreateInfoAndroidKHR;

typedef struct XrGraphicsBindingOpenGLESAndroidKHR
{
    XrStructureType             type;
    const void* XR_MAY_ALIAS    next;
    EGLDisplay                  display;
    EGLConfig                   config;
    EGLContext                  context;
} XrGraphicsBindingOpenGLESAndroidKHR;

typedef struct XrGraphicsRequirementsOpenGLESKHR
{
    XrStructureType             type;
    const void* XR_MAY_ALIAS    next;
    XrVersion                   minApiVersionSupported;
    XrVersion                   maxApiVersionSupported;
} XrGraphicsRequirementsOpenGLESKHR;

typedef XrResult (XRAPI_PTR *PFN_xrGetOpenGLESGraphicsRequirementsKHR)(
    XrInstance instance,
    XrSystemId systemId,
    XrGraphicsRequirementsOpenGLESKHR* graphicsRequirements);

struct EglContextBundle
{
    EGLDisplay display = EGL_NO_DISPLAY;
    EGLConfig config = nullptr;
    EGLContext context = EGL_NO_CONTEXT;
    EGLSurface surface = EGL_NO_SURFACE;
    int clientVersion = 0;

    ~EglContextBundle()
    {
        Shutdown();
    }

    void Shutdown()
    {
        if (display != EGL_NO_DISPLAY)
        {
            eglMakeCurrent(display, EGL_NO_SURFACE, EGL_NO_SURFACE, EGL_NO_CONTEXT);

            if (surface != EGL_NO_SURFACE)
            {
                eglDestroySurface(display, surface);
                surface = EGL_NO_SURFACE;
            }

            if (context != EGL_NO_CONTEXT)
            {
                eglDestroyContext(display, context);
                context = EGL_NO_CONTEXT;
            }

            eglTerminate(display);
            display = EGL_NO_DISPLAY;
        }

        config = nullptr;
        clientVersion = 0;
    }
};

void LogLine(const std::string& line)
{
    __android_log_print(ANDROID_LOG_INFO, kLogTag, "%s", line.c_str());
}

std::string BoolString(bool value)
{
    return value ? "true" : "false";
}

std::string HexString(uint64_t value)
{
    std::ostringstream builder;
    builder << "0x" << std::hex << value;
    return builder.str();
}

std::string ResultName(XrResult result)
{
    switch (result)
    {
        case XR_SUCCESS:
            return "XR_SUCCESS";
        case XR_TIMEOUT_EXPIRED:
            return "XR_TIMEOUT_EXPIRED";
        case XR_ERROR_SESSION_NOT_READY:
            return "XR_ERROR_SESSION_NOT_READY";
        case XR_ERROR_SESSION_NOT_STOPPING:
            return "XR_ERROR_SESSION_NOT_STOPPING";
        case XR_SESSION_LOSS_PENDING:
            return "XR_SESSION_LOSS_PENDING";
        case XR_EVENT_UNAVAILABLE:
            return "XR_EVENT_UNAVAILABLE";
        case XR_ERROR_RUNTIME_FAILURE:
            return "XR_ERROR_RUNTIME_FAILURE";
        case XR_ERROR_INSTANCE_LOST:
            return "XR_ERROR_INSTANCE_LOST";
        case XR_ERROR_SESSION_LOST:
            return "XR_ERROR_SESSION_LOST";
        case XR_ERROR_INITIALIZATION_FAILED:
            return "XR_ERROR_INITIALIZATION_FAILED";
        case XR_ERROR_FUNCTION_UNSUPPORTED:
            return "XR_ERROR_FUNCTION_UNSUPPORTED";
        case XR_ERROR_EXTENSION_NOT_PRESENT:
            return "XR_ERROR_EXTENSION_NOT_PRESENT";
        case XR_ERROR_RUNTIME_UNAVAILABLE:
            return "XR_ERROR_RUNTIME_UNAVAILABLE";
        case XR_ERROR_API_VERSION_UNSUPPORTED:
            return "XR_ERROR_API_VERSION_UNSUPPORTED";
        case XR_ERROR_FORM_FACTOR_UNSUPPORTED:
            return "XR_ERROR_FORM_FACTOR_UNSUPPORTED";
        case XR_ERROR_FORM_FACTOR_UNAVAILABLE:
            return "XR_ERROR_FORM_FACTOR_UNAVAILABLE";
        case XR_ERROR_GRAPHICS_DEVICE_INVALID:
            return "XR_ERROR_GRAPHICS_DEVICE_INVALID";
        case XR_ERROR_GRAPHICS_REQUIREMENTS_CALL_MISSING:
            return "XR_ERROR_GRAPHICS_REQUIREMENTS_CALL_MISSING";
        case XR_ERROR_LIMIT_REACHED:
            return "XR_ERROR_LIMIT_REACHED";
        case XR_ERROR_FEATURE_UNSUPPORTED:
            return "XR_ERROR_FEATURE_UNSUPPORTED";
        case XR_ERROR_VALIDATION_FAILURE:
            return "XR_ERROR_VALIDATION_FAILURE";
        default:
            return std::to_string(result);
    }
}

std::string SessionStateName(XrSessionState state)
{
    switch (state)
    {
        case XR_SESSION_STATE_UNKNOWN:
            return "UNKNOWN";
        case XR_SESSION_STATE_IDLE:
            return "IDLE";
        case XR_SESSION_STATE_READY:
            return "READY";
        case XR_SESSION_STATE_SYNCHRONIZED:
            return "SYNCHRONIZED";
        case XR_SESSION_STATE_VISIBLE:
            return "VISIBLE";
        case XR_SESSION_STATE_FOCUSED:
            return "FOCUSED";
        case XR_SESSION_STATE_STOPPING:
            return "STOPPING";
        case XR_SESSION_STATE_LOSS_PENDING:
            return "LOSS_PENDING";
        case XR_SESSION_STATE_EXITING:
            return "EXITING";
        default:
            return std::to_string(state);
    }
}

std::string BlendModeName(XrEnvironmentBlendMode blendMode)
{
    switch (blendMode)
    {
        case XR_ENVIRONMENT_BLEND_MODE_OPAQUE:
            return "OPAQUE";
        case XR_ENVIRONMENT_BLEND_MODE_ADDITIVE:
            return "ADDITIVE";
        case XR_ENVIRONMENT_BLEND_MODE_ALPHA_BLEND:
            return "ALPHA_BLEND";
        default:
            return std::to_string(blendMode);
    }
}

std::string VersionToString(XrVersion version)
{
    std::ostringstream builder;
    builder
        << XR_VERSION_MAJOR(version) << "."
        << XR_VERSION_MINOR(version) << "."
        << XR_VERSION_PATCH(version);
    return builder.str();
}

bool HasExtension(const std::vector<XrExtensionProperties>& properties, const char* extensionName)
{
    return std::any_of(
        properties.begin(),
        properties.end(),
        [extensionName](const XrExtensionProperties& property)
        {
            return std::strcmp(property.extensionName, extensionName) == 0;
        });
}

std::string ChooseOutputPath(const std::string& internalDataPath, const std::string& externalDataPath)
{
    if (!externalDataPath.empty())
    {
        return externalDataPath + "/" + kOutputFileName;
    }

    if (!internalDataPath.empty())
    {
        return internalDataPath + "/" + kOutputFileName;
    }

    return std::string("/sdcard/") + kOutputFileName;
}

void WriteReportToFile(const std::string& outputPath, const std::string& report)
{
    std::ofstream stream(outputPath, std::ios::out | std::ios::trunc);
    stream << report;
    stream.close();
}

void LogReport(const std::string& report)
{
    std::istringstream stream(report);
    for (std::string line; std::getline(stream, line);)
    {
        LogLine(line);
    }
}

std::string JStringToUtf8(JNIEnv* env, jstring value)
{
    if (value == nullptr)
    {
        return {};
    }

    const char* chars = env->GetStringUTFChars(value, nullptr);
    if (chars == nullptr)
    {
        return {};
    }

    std::string result(chars);
    env->ReleaseStringUTFChars(value, chars);
    return result;
}

template <typename FunctionType>
bool GetFunctionFromProcAddr(
    PFN_xrGetInstanceProcAddr getInstanceProcAddr,
    XrInstance instance,
    const char* functionName,
    FunctionType& function,
    std::string& error)
{
    PFN_xrVoidFunction rawFunction = nullptr;
    const XrResult result = getInstanceProcAddr(instance, functionName, &rawFunction);
    if (XR_FAILED(result) || rawFunction == nullptr)
    {
        error = std::string(functionName) + " -> " + ResultName(result);
        return false;
    }

    function = reinterpret_cast<FunctionType>(rawFunction);
    return true;
}

bool InitializeEglContext(EglContextBundle& egl, std::string& error)
{
    egl.display = eglGetDisplay(EGL_DEFAULT_DISPLAY);
    if (egl.display == EGL_NO_DISPLAY)
    {
        error = "eglGetDisplay failed";
        return false;
    }

    EGLint major = 0;
    EGLint minor = 0;
    if (eglInitialize(egl.display, &major, &minor) != EGL_TRUE)
    {
        error = "eglInitialize failed: " + HexString(static_cast<uint64_t>(eglGetError()));
        return false;
    }

    if (eglBindAPI(EGL_OPENGL_ES_API) != EGL_TRUE)
    {
        error = "eglBindAPI failed: " + HexString(static_cast<uint64_t>(eglGetError()));
        return false;
    }

    const EGLint configAttributes[] = {
        EGL_SURFACE_TYPE, EGL_PBUFFER_BIT,
        EGL_RENDERABLE_TYPE, EGL_OPENGL_ES3_BIT_KHR | EGL_OPENGL_ES2_BIT,
        EGL_RED_SIZE, 8,
        EGL_GREEN_SIZE, 8,
        EGL_BLUE_SIZE, 8,
        EGL_ALPHA_SIZE, 8,
        EGL_DEPTH_SIZE, 16,
        EGL_NONE
    };

    EGLConfig configs[16]{};
    EGLint configCount = 0;
    if (eglChooseConfig(egl.display, configAttributes, configs, 16, &configCount) != EGL_TRUE || configCount == 0)
    {
        error = "eglChooseConfig failed: " + HexString(static_cast<uint64_t>(eglGetError()));
        return false;
    }

    egl.config = configs[0];

    const EGLint pbufferAttributes[] = {
        EGL_WIDTH, 16,
        EGL_HEIGHT, 16,
        EGL_NONE
    };

    egl.surface = eglCreatePbufferSurface(egl.display, egl.config, pbufferAttributes);
    if (egl.surface == EGL_NO_SURFACE)
    {
        error = "eglCreatePbufferSurface failed: " + HexString(static_cast<uint64_t>(eglGetError()));
        return false;
    }

    for (const int clientVersion : {3, 2})
    {
        const EGLint contextAttributes[] = {
            EGL_CONTEXT_CLIENT_VERSION, clientVersion,
            EGL_NONE
        };

        egl.context = eglCreateContext(egl.display, egl.config, EGL_NO_CONTEXT, contextAttributes);
        if (egl.context != EGL_NO_CONTEXT)
        {
            egl.clientVersion = clientVersion;
            break;
        }
    }

    if (egl.context == EGL_NO_CONTEXT)
    {
        error = "eglCreateContext failed: " + HexString(static_cast<uint64_t>(eglGetError()));
        return false;
    }

    if (eglMakeCurrent(egl.display, egl.surface, egl.surface, egl.context) != EGL_TRUE)
    {
        error = "eglMakeCurrent failed: " + HexString(static_cast<uint64_t>(eglGetError()));
        return false;
    }

    return true;
}

std::string BuildProbeReport(
    JNIEnv* env,
    jobject activityContext,
    const std::string& internalDataPath,
    const std::string& externalDataPath)
{
    std::ostringstream report;
    report << "PICO OpenXR Passthrough Probe\n";
    report << "test_goal: compare home mode vs Pico Connect mode for OpenXR session and passthrough viability\n";
    report << "internal_data_path: " << (internalDataPath.empty() ? "<empty>" : internalDataPath) << "\n";
    report << "external_data_path: " << (externalDataPath.empty() ? "<empty>" : externalDataPath) << "\n";
    report << "bundled_loader_name: " << kBundledLoaderName << "\n";

    dlerror();
    void* loaderHandle = dlopen(kBundledLoaderName, RTLD_NOW | RTLD_LOCAL);
    const char* loaderError = dlerror();
    if (loaderHandle == nullptr)
    {
        report << "loader_present: false\n";
        report << "loader_error: " << (loaderError != nullptr ? loaderError : "unknown") << "\n";
        report << "interpretation: the official Khronos Android loader was not found inside the app package.\n";
        return report.str();
    }

    report << "loader_present: true\n";

    auto xrGetInstanceProcAddrFunction =
        reinterpret_cast<PFN_xrGetInstanceProcAddr>(dlsym(loaderHandle, "xrGetInstanceProcAddr"));

    if (xrGetInstanceProcAddrFunction == nullptr)
    {
        const char* symbolError = dlerror();
        report << "xrGetInstanceProcAddr_present: false\n";
        report << "loader_error: " << (symbolError != nullptr ? symbolError : "unknown") << "\n";
        report << "interpretation: the bundled loader was found but does not export xrGetInstanceProcAddr.\n";
        dlclose(loaderHandle);
        return report.str();
    }

    report << "xrGetInstanceProcAddr_present: true\n";

    PFN_xrInitializeLoaderKHR xrInitializeLoaderKHRFunction = nullptr;
    PFN_xrEnumerateInstanceExtensionProperties xrEnumerateInstanceExtensionPropertiesFunction = nullptr;
    PFN_xrCreateInstance xrCreateInstanceFunction = nullptr;
    PFN_xrDestroyInstance xrDestroyInstanceFunction = nullptr;
    PFN_xrGetInstanceProperties xrGetInstancePropertiesFunction = nullptr;

    std::string functionError;
    const bool hasInitializeLoader =
        GetFunctionFromProcAddr(xrGetInstanceProcAddrFunction, XR_NULL_HANDLE, "xrInitializeLoaderKHR", xrInitializeLoaderKHRFunction, functionError);
    report << "xrInitializeLoaderKHR_present: " << BoolString(hasInitializeLoader) << "\n";
    if (!hasInitializeLoader)
    {
        report << "loader_error: " << functionError << "\n";
        report << "interpretation: bundled OpenXR loader is present, but Android loader init is unavailable.\n";
        dlclose(loaderHandle);
        return report.str();
    }

    JavaVM* javaVm = nullptr;
    if (env->GetJavaVM(&javaVm) != JNI_OK || javaVm == nullptr)
    {
        report << "loader_init_result: failed_to_get_JavaVM\n";
        report << "interpretation: JNI did not provide a valid JavaVM pointer for Android loader initialization.\n";
        dlclose(loaderHandle);
        return report.str();
    }

    XrLoaderInitInfoAndroidKHR loaderInitInfo{};
    loaderInitInfo.type = static_cast<XrStructureType>(XR_TYPE_LOADER_INIT_INFO_ANDROID_KHR);
    loaderInitInfo.next = nullptr;
    loaderInitInfo.applicationVM = javaVm;
    loaderInitInfo.applicationContext = activityContext;

    const XrResult loaderInitResult =
        xrInitializeLoaderKHRFunction(reinterpret_cast<const XrLoaderInitInfoBaseHeaderKHR*>(&loaderInitInfo));
    report << "loader_init_result: " << ResultName(loaderInitResult) << "\n";
    if (XR_FAILED(loaderInitResult))
    {
        report << "interpretation: the official loader was present but failed during Android loader initialization.\n";
        dlclose(loaderHandle);
        return report.str();
    }

    if (!GetFunctionFromProcAddr(
            xrGetInstanceProcAddrFunction,
            XR_NULL_HANDLE,
            "xrEnumerateInstanceExtensionProperties",
            xrEnumerateInstanceExtensionPropertiesFunction,
            functionError))
    {
        report << "enumerate_symbol_present: false\n";
        report << "loader_error: " << functionError << "\n";
        report << "interpretation: loader init succeeded, but xrEnumerateInstanceExtensionProperties was still unavailable.\n";
        dlclose(loaderHandle);
        return report.str();
    }

    if (!GetFunctionFromProcAddr(
            xrGetInstanceProcAddrFunction,
            XR_NULL_HANDLE,
            "xrCreateInstance",
            xrCreateInstanceFunction,
            functionError))
    {
        report << "xrCreateInstance_present: false\n";
        report << "loader_error: " << functionError << "\n";
        report << "interpretation: loader init succeeded, but xrCreateInstance was unavailable.\n";
        dlclose(loaderHandle);
        return report.str();
    }

    GetFunctionFromProcAddr(
        xrGetInstanceProcAddrFunction,
        XR_NULL_HANDLE,
        "xrDestroyInstance",
        xrDestroyInstanceFunction,
        functionError);
    GetFunctionFromProcAddr(
        xrGetInstanceProcAddrFunction,
        XR_NULL_HANDLE,
        "xrGetInstanceProperties",
        xrGetInstancePropertiesFunction,
        functionError);

    report << "enumerate_symbol_present: true\n";
    report << "xrCreateInstance_present: true\n";

    uint32_t propertyCount = 0;
    XrResult enumerateResult =
        xrEnumerateInstanceExtensionPropertiesFunction(nullptr, 0, &propertyCount, nullptr);
    report << "enumerate_result: " << ResultName(enumerateResult) << "\n";
    report << "extension_count: " << propertyCount << "\n";

    if (XR_FAILED(enumerateResult))
    {
        report << "interpretation: official loader init succeeded, but extension enumeration failed.\n";
        dlclose(loaderHandle);
        return report.str();
    }

    std::vector<XrExtensionProperties> properties(propertyCount);
    for (auto& property : properties)
    {
        property.type = XR_TYPE_EXTENSION_PROPERTIES;
        property.next = nullptr;
        property.extensionVersion = 0;
        std::memset(property.extensionName, 0, sizeof(property.extensionName));
    }

    enumerateResult = xrEnumerateInstanceExtensionPropertiesFunction(nullptr, propertyCount, &propertyCount, properties.data());
    report << "enumerate_fill_result: " << ResultName(enumerateResult) << "\n";
    report << "extension_count_filled: " << propertyCount << "\n";

    if (XR_FAILED(enumerateResult))
    {
        report << "interpretation: extension allocation succeeded, but the official loader failed to fill the extension list.\n";
        dlclose(loaderHandle);
        return report.str();
    }

    std::sort(
        properties.begin(),
        properties.end(),
        [](const XrExtensionProperties& left, const XrExtensionProperties& right)
        {
            return std::strcmp(left.extensionName, right.extensionName) < 0;
        });

    const bool hasAndroidCreateInstance = HasExtension(properties, kKhrAndroidCreateInstanceExtension);
    const bool hasLoaderInitAndroid = HasExtension(properties, kKhrLoaderInitAndroidExtension);
    const bool hasOpenGlesEnable = HasExtension(properties, kKhrOpenGlesEnableExtension);
    const bool hasCameraImage = HasExtension(properties, kPicoCameraImageExtension);
    const bool hasPicoPassthrough = HasExtension(properties, kPicoPassthroughExtension);
    const bool hasExtFuture = HasExtension(properties, kExtFutureExtension);
    const bool hasSecureMixedReality = HasExtension(properties, kPicoSecureMixedRealityExtension);
    const bool hasExternalCamera = HasExtension(properties, kPicoExternalCameraExtension);
    const bool hasBdExternalCamera = HasExtension(properties, kBdExternalCameraExtension);
    const bool hasBdMrManagement = HasExtension(properties, kBdMrManagementExtension);
    const bool hasFbPassthrough = HasExtension(properties, XR_FB_PASSTHROUGH_EXTENSION_NAME);

    report << "has.XR_KHR_android_create_instance: " << BoolString(hasAndroidCreateInstance) << "\n";
    report << "has.XR_KHR_loader_init_android: " << BoolString(hasLoaderInitAndroid) << "\n";
    report << "has.XR_KHR_opengl_es_enable: " << BoolString(hasOpenGlesEnable) << "\n";
    report << "has.XR_PICO_camera_image: " << BoolString(hasCameraImage) << "\n";
    report << "has.XR_PICO_passthrough: " << BoolString(hasPicoPassthrough) << "\n";
    report << "has.XR_EXT_future: " << BoolString(hasExtFuture) << "\n";
    report << "has.XR_PICO_secure_mixed_reality: " << BoolString(hasSecureMixedReality) << "\n";
    report << "has.XR_PICO_external_camera: " << BoolString(hasExternalCamera) << "\n";
    report << "has.XR_BD_external_camera: " << BoolString(hasBdExternalCamera) << "\n";
    report << "has.XR_BD_mr_management: " << BoolString(hasBdMrManagement) << "\n";
    report << "has.XR_FB_passthrough: " << BoolString(hasFbPassthrough) << "\n";

    report << "extensions:\n";
    for (const auto& property : properties)
    {
        report << "  - " << property.extensionName << " (spec_version=" << property.extensionVersion << ")\n";
    }

    if (!hasAndroidCreateInstance)
    {
        report << "instance_create_result: skipped_missing_XR_KHR_android_create_instance\n";
        report << "interpretation: extension enumeration worked, but the runtime did not advertise XR_KHR_android_create_instance.\n";
        dlclose(loaderHandle);
        return report.str();
    }

    std::vector<const char*> enabledExtensions;
    enabledExtensions.push_back(kKhrAndroidCreateInstanceExtension);
    if (hasOpenGlesEnable)
    {
        enabledExtensions.push_back(kKhrOpenGlesEnableExtension);
    }
    if (hasFbPassthrough)
    {
        enabledExtensions.push_back(XR_FB_PASSTHROUGH_EXTENSION_NAME);
    }

    XrInstanceCreateInfoAndroidKHR androidCreateInfo{};
    androidCreateInfo.type = static_cast<XrStructureType>(XR_TYPE_INSTANCE_CREATE_INFO_ANDROID_KHR);
    androidCreateInfo.next = nullptr;
    androidCreateInfo.applicationVM = javaVm;
    androidCreateInfo.applicationActivity = activityContext;

    XrInstanceCreateInfo createInfo{XR_TYPE_INSTANCE_CREATE_INFO};
    createInfo.next = &androidCreateInfo;
    std::strncpy(createInfo.applicationInfo.applicationName, "PicoOpenXrProbe", XR_MAX_APPLICATION_NAME_SIZE - 1);
    createInfo.applicationInfo.applicationVersion = 2;
    std::strncpy(createInfo.applicationInfo.engineName, "VRRealityWindow", XR_MAX_ENGINE_NAME_SIZE - 1);
    createInfo.applicationInfo.engineVersion = 2;
    createInfo.applicationInfo.apiVersion = XR_CURRENT_API_VERSION;
    createInfo.enabledApiLayerCount = 0;
    createInfo.enabledApiLayerNames = nullptr;
    createInfo.enabledExtensionCount = static_cast<uint32_t>(enabledExtensions.size());
    createInfo.enabledExtensionNames = enabledExtensions.data();

    XrInstance instance = XR_NULL_HANDLE;
    const XrResult createInstanceResult = xrCreateInstanceFunction(&createInfo, &instance);
    report << "instance_create_result: " << ResultName(createInstanceResult) << "\n";

    if (XR_FAILED(createInstanceResult) || instance == XR_NULL_HANDLE)
    {
        report << "interpretation: the loader and extension list worked, but instance creation failed in this launch mode.\n";
        dlclose(loaderHandle);
        return report.str();
    }

    if (xrGetInstancePropertiesFunction != nullptr)
    {
        XrInstanceProperties instanceProperties{XR_TYPE_INSTANCE_PROPERTIES};
        const XrResult propertiesResult = xrGetInstancePropertiesFunction(instance, &instanceProperties);
        report << "instance_properties_result: " << ResultName(propertiesResult) << "\n";
        if (XR_SUCCEEDED(propertiesResult))
        {
            report << "runtime_name: " << instanceProperties.runtimeName << "\n";
            report << "runtime_version: " << VersionToString(instanceProperties.runtimeVersion) << "\n";
        }
    }

    PFN_xrGetSystem xrGetSystemFunction = nullptr;
    PFN_xrGetSystemProperties xrGetSystemPropertiesFunction = nullptr;
    PFN_xrEnumerateEnvironmentBlendModes xrEnumerateEnvironmentBlendModesFunction = nullptr;
    PFN_xrCreateSession xrCreateSessionFunction = nullptr;
    PFN_xrDestroySession xrDestroySessionFunction = nullptr;
    PFN_xrPollEvent xrPollEventFunction = nullptr;
    PFN_xrBeginSession xrBeginSessionFunction = nullptr;
    PFN_xrEndSession xrEndSessionFunction = nullptr;
    PFN_xrGetOpenGLESGraphicsRequirementsKHR xrGetOpenGLESGraphicsRequirementsKHRFunction = nullptr;

    bool haveAllCoreSessionFns = true;
    haveAllCoreSessionFns &= GetFunctionFromProcAddr(
        xrGetInstanceProcAddrFunction, instance, "xrGetSystem", xrGetSystemFunction, functionError);
    haveAllCoreSessionFns &= GetFunctionFromProcAddr(
        xrGetInstanceProcAddrFunction, instance, "xrGetSystemProperties", xrGetSystemPropertiesFunction, functionError);
    haveAllCoreSessionFns &= GetFunctionFromProcAddr(
        xrGetInstanceProcAddrFunction, instance, "xrCreateSession", xrCreateSessionFunction, functionError);
    haveAllCoreSessionFns &= GetFunctionFromProcAddr(
        xrGetInstanceProcAddrFunction, instance, "xrDestroySession", xrDestroySessionFunction, functionError);
    haveAllCoreSessionFns &= GetFunctionFromProcAddr(
        xrGetInstanceProcAddrFunction, instance, "xrPollEvent", xrPollEventFunction, functionError);
    haveAllCoreSessionFns &= GetFunctionFromProcAddr(
        xrGetInstanceProcAddrFunction, instance, "xrBeginSession", xrBeginSessionFunction, functionError);
    haveAllCoreSessionFns &= GetFunctionFromProcAddr(
        xrGetInstanceProcAddrFunction, instance, "xrEndSession", xrEndSessionFunction, functionError);
    GetFunctionFromProcAddr(
        xrGetInstanceProcAddrFunction, instance, "xrEnumerateEnvironmentBlendModes", xrEnumerateEnvironmentBlendModesFunction, functionError);

    report << "core_session_functions_present: " << BoolString(haveAllCoreSessionFns) << "\n";
    if (!haveAllCoreSessionFns)
    {
        report << "session_bootstrap_error: " << functionError << "\n";
    }

    XrSystemGetInfo systemGetInfo{XR_TYPE_SYSTEM_GET_INFO};
    systemGetInfo.formFactor = XR_FORM_FACTOR_HEAD_MOUNTED_DISPLAY;

    XrSystemId systemId = XR_NULL_SYSTEM_ID;
    const XrResult systemResult = xrGetSystemFunction(instance, &systemGetInfo, &systemId);
    LogLine(std::string("checkpoint.system_get_result=") + ResultName(systemResult));
    report << "system_get_result: " << ResultName(systemResult) << "\n";
    report << "system_id_valid: " << BoolString(XR_SUCCEEDED(systemResult) && systemId != XR_NULL_SYSTEM_ID) << "\n";

    XrSystemPassthroughPropertiesFB passthroughProps{XR_TYPE_SYSTEM_PASSTHROUGH_PROPERTIES_FB};
    XrSystemPassthroughProperties2FB passthroughProps2{XR_TYPE_SYSTEM_PASSTHROUGH_PROPERTIES2_FB};
    passthroughProps.next = hasFbPassthrough ? &passthroughProps2 : nullptr;

    if (XR_SUCCEEDED(systemResult) && systemId != XR_NULL_SYSTEM_ID)
    {
        XrSystemProperties systemProperties{XR_TYPE_SYSTEM_PROPERTIES};
        systemProperties.next = hasFbPassthrough ? &passthroughProps : nullptr;
        const XrResult systemPropertiesResult = xrGetSystemPropertiesFunction(instance, systemId, &systemProperties);
        report << "system_properties_result: " << ResultName(systemPropertiesResult) << "\n";

        if (XR_SUCCEEDED(systemPropertiesResult))
        {
            report << "system_name: " << systemProperties.systemName << "\n";
            report << "system_vendor_id: " << systemProperties.vendorId << "\n";
            report << "tracking.orientation: " << BoolString(systemProperties.trackingProperties.orientationTracking == XR_TRUE) << "\n";
            report << "tracking.position: " << BoolString(systemProperties.trackingProperties.positionTracking == XR_TRUE) << "\n";
            report << "graphics.max_swapchain_width: " << systemProperties.graphicsProperties.maxSwapchainImageWidth << "\n";
            report << "graphics.max_swapchain_height: " << systemProperties.graphicsProperties.maxSwapchainImageHeight << "\n";

            if (hasFbPassthrough)
            {
                report << "fb_passthrough.supports_passthrough: " << BoolString(passthroughProps.supportsPassthrough == XR_TRUE) << "\n";
                report << "fb_passthrough.capabilities: " << HexString(static_cast<uint64_t>(passthroughProps2.capabilities)) << "\n";
            }
        }

        if (xrEnumerateEnvironmentBlendModesFunction != nullptr)
        {
            uint32_t blendModeCount = 0;
            XrResult blendModeResult = xrEnumerateEnvironmentBlendModesFunction(
                instance,
                systemId,
                XR_VIEW_CONFIGURATION_TYPE_PRIMARY_STEREO,
                0,
                &blendModeCount,
                nullptr);
            report << "blend_mode_enumerate_result: " << ResultName(blendModeResult) << "\n";
            report << "blend_mode_count: " << blendModeCount << "\n";

            if (XR_SUCCEEDED(blendModeResult) && blendModeCount > 0)
            {
                std::vector<XrEnvironmentBlendMode> blendModes(blendModeCount);
                blendModeResult = xrEnumerateEnvironmentBlendModesFunction(
                    instance,
                    systemId,
                    XR_VIEW_CONFIGURATION_TYPE_PRIMARY_STEREO,
                    blendModeCount,
                    &blendModeCount,
                    blendModes.data());
                report << "blend_mode_fill_result: " << ResultName(blendModeResult) << "\n";
                if (XR_SUCCEEDED(blendModeResult))
                {
                    report << "blend_modes:\n";
                    for (const XrEnvironmentBlendMode blendMode : blendModes)
                    {
                        report << "  - " << BlendModeName(blendMode) << "\n";
                    }
                }
            }
        }
    }

    XrSession session = XR_NULL_HANDLE;
    bool sessionBegun = false;
    XrSessionState lastSessionState = XR_SESSION_STATE_UNKNOWN;
    XrResult createSessionResult = XR_ERROR_RUNTIME_FAILURE;
    XrResult beginSessionResult = XR_ERROR_SESSION_NOT_READY;
    XrResult passthroughCreateResult = XR_ERROR_FEATURE_UNSUPPORTED;
    XrResult passthroughStartResult = XR_ERROR_FEATURE_UNSUPPORTED;
    XrResult passthroughLayerCreateResult = XR_ERROR_FEATURE_UNSUPPORTED;
    XrResult passthroughLayerResumeResult = XR_ERROR_FEATURE_UNSUPPORTED;

    EglContextBundle egl;

    if (!hasOpenGlesEnable)
    {
        report << "graphics_binding_result: skipped_missing_XR_KHR_opengl_es_enable\n";
    }
    else if (XR_SUCCEEDED(systemResult) && systemId != XR_NULL_SYSTEM_ID)
    {
        if (!GetFunctionFromProcAddr(
                xrGetInstanceProcAddrFunction,
                instance,
                "xrGetOpenGLESGraphicsRequirementsKHR",
                xrGetOpenGLESGraphicsRequirementsKHRFunction,
                functionError))
        {
            report << "xrGetOpenGLESGraphicsRequirementsKHR_present: false\n";
            report << "graphics_binding_error: " << functionError << "\n";
        }
        else
        {
            report << "xrGetOpenGLESGraphicsRequirementsKHR_present: true\n";

            XrGraphicsRequirementsOpenGLESKHR graphicsRequirements{};
            graphicsRequirements.type = static_cast<XrStructureType>(XR_TYPE_GRAPHICS_REQUIREMENTS_OPENGL_ES_KHR);
            const XrResult graphicsRequirementsResult =
                xrGetOpenGLESGraphicsRequirementsKHRFunction(instance, systemId, &graphicsRequirements);
            LogLine(std::string("checkpoint.graphics_requirements_result=") + ResultName(graphicsRequirementsResult));
            report << "graphics_requirements_result: " << ResultName(graphicsRequirementsResult) << "\n";
            if (XR_SUCCEEDED(graphicsRequirementsResult))
            {
                report << "graphics.min_api_version: " << VersionToString(graphicsRequirements.minApiVersionSupported) << "\n";
                report << "graphics.max_api_version: " << VersionToString(graphicsRequirements.maxApiVersionSupported) << "\n";
            }

            std::string eglError;
            const bool eglReady = InitializeEglContext(egl, eglError);
            report << "egl_init_result: " << BoolString(eglReady) << "\n";
            if (eglReady)
            {
                report << "egl_client_version: " << egl.clientVersion << "\n";
            }
            else
            {
                report << "egl_error: " << eglError << "\n";
            }

            if (XR_SUCCEEDED(graphicsRequirementsResult) && eglReady)
            {
                XrGraphicsBindingOpenGLESAndroidKHR graphicsBinding{};
                graphicsBinding.type = static_cast<XrStructureType>(XR_TYPE_GRAPHICS_BINDING_OPENGL_ES_ANDROID_KHR);
                graphicsBinding.next = nullptr;
                graphicsBinding.display = egl.display;
                graphicsBinding.config = egl.config;
                graphicsBinding.context = egl.context;

                XrSessionCreateInfo sessionCreateInfo{XR_TYPE_SESSION_CREATE_INFO};
                sessionCreateInfo.next = &graphicsBinding;
                sessionCreateInfo.createFlags = 0;
                sessionCreateInfo.systemId = systemId;

                LogLine("checkpoint.before_xrCreateSession");
                createSessionResult = xrCreateSessionFunction(instance, &sessionCreateInfo, &session);
                LogLine(std::string("checkpoint.after_xrCreateSession=") + ResultName(createSessionResult));
                report << "session_create_result: " << ResultName(createSessionResult) << "\n";

                if (XR_SUCCEEDED(createSessionResult) && session != XR_NULL_HANDLE)
                {
                    XrEventDataBuffer eventBuffer{XR_TYPE_EVENT_DATA_BUFFER};

                    for (int iteration = 0; iteration < 60; ++iteration)
                    {
                        while (xrPollEventFunction(instance, &eventBuffer) == XR_SUCCESS)
                        {
                            const auto* baseHeader = reinterpret_cast<const XrEventDataBaseHeader*>(&eventBuffer);
                            if (baseHeader->type == XR_TYPE_EVENT_DATA_SESSION_STATE_CHANGED)
                            {
                                const auto* sessionStateChanged =
                                    reinterpret_cast<const XrEventDataSessionStateChanged*>(&eventBuffer);
                                lastSessionState = sessionStateChanged->state;
                                report << "session_state_event: " << SessionStateName(lastSessionState) << "\n";

                                if (!sessionBegun && lastSessionState == XR_SESSION_STATE_READY)
                                {
                                    XrSessionBeginInfo beginInfo{XR_TYPE_SESSION_BEGIN_INFO};
                                    beginInfo.primaryViewConfigurationType = XR_VIEW_CONFIGURATION_TYPE_PRIMARY_STEREO;
                                    LogLine("checkpoint.before_xrBeginSession");
                                    beginSessionResult = xrBeginSessionFunction(session, &beginInfo);
                                    LogLine(std::string("checkpoint.after_xrBeginSession=") + ResultName(beginSessionResult));
                                    report << "session_begin_result: " << ResultName(beginSessionResult) << "\n";
                                    sessionBegun = XR_SUCCEEDED(beginSessionResult);
                                }
                            }

                            eventBuffer = XrEventDataBuffer{XR_TYPE_EVENT_DATA_BUFFER};
                        }

                        if (sessionBegun || lastSessionState == XR_SESSION_STATE_STOPPING || lastSessionState == XR_SESSION_STATE_EXITING)
                        {
                            break;
                        }

                        std::this_thread::sleep_for(std::chrono::milliseconds(50));
                    }

                    report << "session_state_final: " << SessionStateName(lastSessionState) << "\n";

                    if (hasFbPassthrough)
                    {
                        PFN_xrCreatePassthroughFB xrCreatePassthroughFBFunction = nullptr;
                        PFN_xrDestroyPassthroughFB xrDestroyPassthroughFBFunction = nullptr;
                        PFN_xrPassthroughStartFB xrPassthroughStartFBFunction = nullptr;
                        PFN_xrCreatePassthroughLayerFB xrCreatePassthroughLayerFBFunction = nullptr;
                        PFN_xrDestroyPassthroughLayerFB xrDestroyPassthroughLayerFBFunction = nullptr;
                        PFN_xrPassthroughLayerResumeFB xrPassthroughLayerResumeFBFunction = nullptr;

                        const bool havePassthroughFns =
                            GetFunctionFromProcAddr(
                                xrGetInstanceProcAddrFunction,
                                instance,
                                "xrCreatePassthroughFB",
                                xrCreatePassthroughFBFunction,
                                functionError) &&
                            GetFunctionFromProcAddr(
                                xrGetInstanceProcAddrFunction,
                                instance,
                                "xrDestroyPassthroughFB",
                                xrDestroyPassthroughFBFunction,
                                functionError) &&
                            GetFunctionFromProcAddr(
                                xrGetInstanceProcAddrFunction,
                                instance,
                                "xrPassthroughStartFB",
                                xrPassthroughStartFBFunction,
                                functionError) &&
                            GetFunctionFromProcAddr(
                                xrGetInstanceProcAddrFunction,
                                instance,
                                "xrCreatePassthroughLayerFB",
                                xrCreatePassthroughLayerFBFunction,
                                functionError) &&
                            GetFunctionFromProcAddr(
                                xrGetInstanceProcAddrFunction,
                                instance,
                                "xrDestroyPassthroughLayerFB",
                                xrDestroyPassthroughLayerFBFunction,
                                functionError) &&
                            GetFunctionFromProcAddr(
                                xrGetInstanceProcAddrFunction,
                                instance,
                                "xrPassthroughLayerResumeFB",
                                xrPassthroughLayerResumeFBFunction,
                                functionError);

                        report << "fb_passthrough.functions_present: " << BoolString(havePassthroughFns) << "\n";
                        if (!havePassthroughFns)
                        {
                            report << "fb_passthrough.function_error: " << functionError << "\n";
                        }
                        else
                        {
                            XrPassthroughFB passthroughHandle = XR_NULL_HANDLE;
                            XrPassthroughLayerFB passthroughLayerHandle = XR_NULL_HANDLE;

                            XrPassthroughCreateInfoFB passthroughCreateInfo{XR_TYPE_PASSTHROUGH_CREATE_INFO_FB};
                            passthroughCreateInfo.flags = XR_PASSTHROUGH_IS_RUNNING_AT_CREATION_BIT_FB;
                            LogLine("checkpoint.before_xrCreatePassthroughFB");
                            passthroughCreateResult = xrCreatePassthroughFBFunction(session, &passthroughCreateInfo, &passthroughHandle);
                            LogLine(std::string("checkpoint.after_xrCreatePassthroughFB=") + ResultName(passthroughCreateResult));
                            report << "fb_passthrough.create_result: " << ResultName(passthroughCreateResult) << "\n";

                            if (XR_SUCCEEDED(passthroughCreateResult))
                            {
                                LogLine("checkpoint.before_xrPassthroughStartFB");
                                passthroughStartResult = xrPassthroughStartFBFunction(passthroughHandle);
                                LogLine(std::string("checkpoint.after_xrPassthroughStartFB=") + ResultName(passthroughStartResult));
                                report << "fb_passthrough.start_result: " << ResultName(passthroughStartResult) << "\n";

                                XrPassthroughLayerCreateInfoFB passthroughLayerCreateInfo{XR_TYPE_PASSTHROUGH_LAYER_CREATE_INFO_FB};
                                passthroughLayerCreateInfo.passthrough = passthroughHandle;
                                passthroughLayerCreateInfo.flags = XR_PASSTHROUGH_IS_RUNNING_AT_CREATION_BIT_FB;
                                passthroughLayerCreateInfo.purpose = XR_PASSTHROUGH_LAYER_PURPOSE_RECONSTRUCTION_FB;
                                LogLine("checkpoint.before_xrCreatePassthroughLayerFB");
                                passthroughLayerCreateResult =
                                    xrCreatePassthroughLayerFBFunction(session, &passthroughLayerCreateInfo, &passthroughLayerHandle);
                                LogLine(std::string("checkpoint.after_xrCreatePassthroughLayerFB=") + ResultName(passthroughLayerCreateResult));
                                report << "fb_passthrough.layer_create_result: " << ResultName(passthroughLayerCreateResult) << "\n";

                                if (XR_SUCCEEDED(passthroughLayerCreateResult))
                                {
                                    LogLine("checkpoint.before_xrPassthroughLayerResumeFB");
                                    passthroughLayerResumeResult = xrPassthroughLayerResumeFBFunction(passthroughLayerHandle);
                                    LogLine(std::string("checkpoint.after_xrPassthroughLayerResumeFB=") + ResultName(passthroughLayerResumeResult));
                                    report << "fb_passthrough.layer_resume_result: " << ResultName(passthroughLayerResumeResult) << "\n";
                                }
                            }

                            if (passthroughLayerHandle != XR_NULL_HANDLE)
                            {
                                const XrResult destroyLayerResult = xrDestroyPassthroughLayerFBFunction(passthroughLayerHandle);
                                report << "fb_passthrough.layer_destroy_result: " << ResultName(destroyLayerResult) << "\n";
                            }

                            if (passthroughHandle != XR_NULL_HANDLE)
                            {
                                const XrResult destroyPassthroughResult = xrDestroyPassthroughFBFunction(passthroughHandle);
                                report << "fb_passthrough.destroy_result: " << ResultName(destroyPassthroughResult) << "\n";
                            }
                        }
                    }

                    if (sessionBegun)
                    {
                        const XrResult endSessionResult = xrEndSessionFunction(session);
                        report << "session_end_result: " << ResultName(endSessionResult) << "\n";
                    }

                    const XrResult destroySessionResult = xrDestroySessionFunction(session);
                    report << "session_destroy_result: " << ResultName(destroySessionResult) << "\n";
                    session = XR_NULL_HANDLE;
                }
            }
        }
    }

    if (xrDestroyInstanceFunction != nullptr && instance != XR_NULL_HANDLE)
    {
        const XrResult destroyInstanceResult = xrDestroyInstanceFunction(instance);
        report << "instance_destroy_result: " << ResultName(destroyInstanceResult) << "\n";
    }

    if (XR_SUCCEEDED(createSessionResult) &&
        XR_SUCCEEDED(passthroughCreateResult) &&
        XR_SUCCEEDED(passthroughLayerCreateResult))
    {
        report << "coexistence_verdict: current launch mode accepted session creation and FB passthrough object creation\n";
        report << "interpretation: compare this result between headset home mode and active Pico Connect mode. If it fails only under Pico Connect, streaming coexistence is the blocker.\n";
    }
    else if (XR_SUCCEEDED(createSessionResult) && hasFbPassthrough)
    {
        report << "coexistence_verdict: session creation worked, but FB passthrough creation did not fully succeed in this launch mode\n";
        report << "interpretation: this points to a passthrough availability/compositor restriction rather than a basic OpenXR loader problem.\n";
    }
    else if (XR_SUCCEEDED(createInstanceResult) && XR_SUCCEEDED(systemResult))
    {
        report << "coexistence_verdict: runtime and system were reachable, but immersive session creation did not complete in this launch mode\n";
        report << "interpretation: if this happens only while Pico Connect is active, then multi-app streaming coexistence is likely blocked on this device/runtime path.\n";
    }
    else if (hasCameraImage && hasExtFuture)
    {
        report << "interpretation: official loader path works and the raw camera extension is advertised. Next step is a capture-session probe.\n";
    }
    else if (hasPicoPassthrough || hasFbPassthrough || hasBdExternalCamera || hasBdMrManagement)
    {
        report << "interpretation: official loader path works. Raw camera extensions are absent, but passthrough/MR-related extensions are present. The next probe should compare Home mode vs Pico Connect mode with this report.\n";
    }
    else if (!hasCameraImage && hasSecureMixedReality)
    {
        report << "interpretation: official loader path works, but only SecureMR-style access is visible so far. Raw camera ownership is still not proven.\n";
    }
    else if (!hasCameraImage)
    {
        report << "interpretation: official loader path works, but XR_PICO_camera_image is not advertised in the extension list.\n";
    }

    dlclose(loaderHandle);
    return report.str();
}
} // namespace

extern "C" JNIEXPORT jstring JNICALL
Java_com_vrapp_picoopenxrextensionprobe_MainActivity_runProbeNative(
    JNIEnv* env,
    jobject thiz,
    jstring internalDataPath,
    jstring externalDataPath)
{
    const std::string internalPath = JStringToUtf8(env, internalDataPath);
    const std::string externalPath = JStringToUtf8(env, externalDataPath);
    const std::string outputPath = ChooseOutputPath(internalPath, externalPath);

    LogLine("probe_started");
    const std::string report = BuildProbeReport(env, thiz, internalPath, externalPath);
    WriteReportToFile(outputPath, report);
    LogReport(report);
    LogLine("probe_finished");

    return env->NewStringUTF(report.c_str());
}
