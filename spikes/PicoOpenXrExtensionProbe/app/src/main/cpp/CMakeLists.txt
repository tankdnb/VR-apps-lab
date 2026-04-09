cmake_minimum_required(VERSION 3.22.1)
project(pico_openxr_extension_probe LANGUAGES C CXX)

set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

add_library(pico_openxr_extension_probe SHARED
    main.cpp)

target_include_directories(pico_openxr_extension_probe PRIVATE
    "${CMAKE_CURRENT_SOURCE_DIR}/third_party/openxr")

find_library(log-lib log)
find_library(dl-lib dl)
find_library(egl-lib EGL)
find_library(glesv3-lib GLESv3)

target_link_libraries(pico_openxr_extension_probe PRIVATE
    ${log-lib}
    ${dl-lib}
    ${egl-lib}
    ${glesv3-lib})
