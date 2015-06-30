A C# wrapper for My.jdownloader.org API.

This is a rewritten version of this PHP wrapper https://github.com/tofika/my.jdownloader.org-api-php-class

Usage:

First, you need JDownloader 2 Beta installed on your PC or other hardware, visit http://jdownloader.org/download/offline.


Setup JDownloader for my.jdownloader.org in Settings/My.JDownloader.


If you already registered at my.jdownloader.org than simply fill fields Username/Email, Password and Device Name, otherwise press button "Go to My.JDownloader.org" and complete registration.


Now you can initialize the class
```C#
var jDownloader = new JDownloader();
```
Connect to my.jdownloader.org
```C#
jDownloader.Connect("email", "password");
```
Enumerate Devices
```C#
jDownloader.EnumerateDevices();
```
You can choose device with device's name
```C#
var yourdevice = jDownloader.Devices.FirstOrDefault(x => x.name == "Your device's name");
```
or select first device in device list
```C#
var yourdevice = jDownloader.Devices[0];
```
Add links to jdownloader and start it
```C#
jDownloader.AddLink(yourdevice, "download link", "package name");
```
Available methods: connect, reconnect, disconnect, enumerateDevices, getDirectConnectionInfos, callAction, addLink, start, stop and more maybe later.

Copyright (c) 2015 Dung Lee
