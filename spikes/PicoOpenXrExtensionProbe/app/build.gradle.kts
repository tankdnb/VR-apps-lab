plugins {
    id("com.android.application")
}

android {
    namespace = "com.vrapp.picoopenxrextensionprobe"
    compileSdk = 34

    defaultConfig {
        applicationId = "com.vrapp.picoopenxrextensionprobe"
        minSdk = 29
        targetSdk = 34
        versionCode = 1
        versionName = "0.1.0"

        ndk {
            abiFilters += listOf("arm64-v8a")
        }

        externalNativeBuild {
            cmake {
                arguments += listOf("-DANDROID_STL=c++_shared")
            }
        }
    }

    buildTypes {
        debug {
            isMinifyEnabled = false
        }

        release {
            isMinifyEnabled = false
        }
    }

    externalNativeBuild {
        cmake {
            path = file("src/main/cpp/CMakeLists.txt")
            version = "3.22.1"
        }
    }

    buildFeatures {
        prefab = true
    }
}

dependencies {
    implementation("org.khronos.openxr:openxr_loader_for_android:1.1.48")
}
