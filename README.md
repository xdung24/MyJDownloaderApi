A C# wrapper for My.jdownloader.org API.
Usage:
First, you need JDownloader 2 Beta installed on your PC or other hardware, visit http://jdownloader.org/download/offline.

Setup JDownloader for my.jdownloader.org in Settings/My.JDownloader.

If you already registered at my.jdownloader.org than simply fill fields Username/Email, Password and Device Name, otherwise press button "Go to My.JDownloader.org" and complete registration.

Now you can initialize the class
var jDownloader = new JDownloader();
Connect to my.jdownloader.org
Downloader.Connect("email", "password");
Enumerate Devices
jDownloader.EnumerateDevices();
You can choose device with device's name
var yourdevice = jDownloader.Devices.FirstOrDefault(x => x.name == "JDownloader@DungLe");
or select first device in device list
var yourdevice = jDownloader.Devices[0];
Build links array
var links = new[]{
	"some link"
};
Add links to jdownloader and start it
jDownloader.AddLinks(yourdevice, links, "package name");