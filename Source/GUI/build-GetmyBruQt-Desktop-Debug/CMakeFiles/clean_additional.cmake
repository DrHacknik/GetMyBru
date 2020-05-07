# Additional clean files
cmake_minimum_required(VERSION 3.16)

if("${CONFIG}" STREQUAL "" OR "${CONFIG}" STREQUAL "Debug")
  file(REMOVE_RECURSE
  "CMakeFiles/GetmyBruQt_autogen.dir/AutogenUsed.txt"
  "CMakeFiles/GetmyBruQt_autogen.dir/ParseCache.txt"
  "GetmyBruQt_autogen"
  )
endif()
