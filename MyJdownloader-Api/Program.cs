using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyJdownloader_Api
{
    static class Program
    {
        static void Main(string[] args)
        {
            string email = "email";
            string password = "password";
            var jDownloader = new JDownloader();
            Console.WriteLine("Connect:" + jDownloader.Connect(email, password));
            Console.WriteLine("EnumerateDevices:" + jDownloader.EnumerateDevices());
            foreach (var device in jDownloader.Devices)
            {
                Console.WriteLine("{0}:{1}",device.name,device.id  );
            }
            var yourdevice = jDownloader.Devices.FirstOrDefault(x => x.name == "your device name");
            var links = new[]
            {
                "https://www.youtube.com/watch?v=QcIy9NiNbmo"
            };
            string package = "Test package";
            Console.WriteLine("AddLinks:" + jDownloader.AddLinks(yourdevice, links, package));

        }
    }
}
