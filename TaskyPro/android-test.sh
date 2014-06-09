#!/bin/bash
export APK=Tasky.Droid/bin/Release/com.xamarin.samples.taskydroid-Signed.apk
export ADB_DEVICE_ARG=192.168.56.101:5555
calabash-android run $APK -p android
