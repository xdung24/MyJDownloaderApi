using System;
using System.Linq;

namespace MyJdownloader_Api
{
    static class Program
    {
        static void Main(string[] args)
        {
            string email = "EMAIL";
            string password = "PASSWORD";
            var jDownloader = new JDownloader();
            Console.WriteLine("Connect:" + jDownloader.Connect(email, password));
            Console.WriteLine("EnumerateDevices:" + jDownloader.EnumerateDevices());
            foreach (var device in jDownloader.Devices)
            {
                Console.WriteLine("{0}:{1}", device.Name, device.Id);
            }
            var yourdevice = jDownloader.Devices.FirstOrDefault(x => x.Name == "JDOWNLOADER_DEVICE");
            var link = "DOWNLOAD_LINK";
            string package = "PACKAGE_NAME";
            Console.WriteLine("AddLinks:" + jDownloader.AddLink(yourdevice, link, package));
        }
    }
}
