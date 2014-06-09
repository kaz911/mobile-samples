#!/bin/bash
export APK=Tasky.Droid/bin/Release/com.xamarin.samples.taskydroid-Signed.apk
export ADB_DEVICE_ARG=192.168.56.101:5555 # Genymotion, Galaxy S3 w/Android 4.2.2
calabash-android console $APK -p android