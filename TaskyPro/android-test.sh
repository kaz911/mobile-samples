#!/bin/bash
# This assumes you have an Android Emulator or Genymotion running at $ADB_DEVICE_ARG
export APK=Tasky.Droid/bin/Release/com.xamarin.samples.taskydroid-Signed.apk
export ADB_DEVICE_ARG=192.168.56.101:5555
export SCREENSHOT_PATH=./screenshots/

mkdir -p $SCREENSHOT_PATH
#/Applications/Genymotion.app/Contents/MacOS/player --vm-name "Android 4.4.2"

calabash-android run $APK -p android
