using System;
using RandomDeviceGen;
using RandomLanguageGen;

namespace NLPLogix.Core.Environmental
{
    public class PreReq
    {

        public void BrowserStartUpConfig(string headless)
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomLang langName = new RandomLang(rand);
            RandomDev RandomDevice = new RandomDev(rand);
            string Device = RandomDevice.Generate();
            NLPLogix.Device = Device;

            if(Device.Equals("BlackBerry Z30") || Device.Equals("Galaxy Note 3") || Device.Equals("Galaxy Note II") || Device.Equals("Galaxy S III") || Device.Equals("Microsoft Lumia 950")
                 || Device.Equals("Moto G4") || Device.Equals("Nexus 5") || Device.Equals("Galaxy S5"))
            {
                if(Device.Equals("Microsoft Lumia 950") || Device.Equals("Moto G4")) 
                {
                    NLPLogix.Browser = "Edge";
                } 
                else if (Device.Equals("Nexus 5"))
                {
                    NLPLogix.Browser = "Edge";
                } else
                {
                    NLPLogix.Browser = "Chrome";
                }
                NLPLogix.WindowSizeX = 360;
                NLPLogix.WindowSizeY = 640;
            }
            else if(Device.Equals("Blackberry PlayBook") || Device.Equals("Nest Hub"))
            {
                NLPLogix.Browser = "Chrome";
                NLPLogix.WindowSizeX = 1024;
                NLPLogix.WindowSizeY = 600;
            }
            else if(Device.Equals("Galaxy S8") || Device.Equals("Galaxy S8+"))
            {
                NLPLogix.Browser = "Chrome";
                NLPLogix.WindowSizeX = 360;
                NLPLogix.WindowSizeY = 740;
            }
            else if(Device.Equals("Galaxy S9+"))
            {
                NLPLogix.Browser = "Chrome";
                NLPLogix.WindowSizeX = 320;
                NLPLogix.WindowSizeY = 658;
            }
            else if(Device.Equals("Galaxy Tab S4"))
            {
                NLPLogix.Browser = "Chrome";
                NLPLogix.WindowSizeX = 1138;
                NLPLogix.WindowSizeY = 712;
            }
            else if(Device.Equals("Kindle Fire HDX") || Device.Equals("Nexus 10") || Device.Equals("Nest Hub Max"))
            {
                if(Device.Equals("Kindle Fire HDX"))
                {
                    NLPLogix.Browser = "Firefox";
                }
                else if (Device.Equals("Nexus 10"))
                {
                    NLPLogix.Browser = "Edge";
                }
                else
                {
                    NLPLogix.Browser = "Chrome";
                }
                NLPLogix.WindowSizeX = 1280;
                NLPLogix.WindowSizeY = 800;
            }
            else if (Device.Equals("LG Optimus L70") || Device.Equals("Nexus 4"))
            {
                NLPLogix.Browser = "Chrome";
                NLPLogix.WindowSizeX = 384;
                NLPLogix.WindowSizeY = 640;
            }
            else if(Device.Equals("Microsoft Lumia 550"))
            {
                NLPLogix.Browser = "Edge";
                NLPLogix.WindowSizeX = 640;
                NLPLogix.WindowSizeY = 360;
            }
            else if(Device.Equals("Moto G Power"))
            {
                NLPLogix.Browser = "Edge";
                NLPLogix.WindowSizeX = 412;
                NLPLogix.WindowSizeY = 823;
            }
            else if(Device.Equals("Nexus 5X") || Device.Equals("Nexus 6") || Device.Equals("Nexus 6P"))
            {
                NLPLogix.Browser = "Edge";
                NLPLogix.WindowSizeX = 412;
                NLPLogix.WindowSizeY = 732;
            }
            else if(Device.Equals("Nexus 7"))
            {
                NLPLogix.Browser = "Edge";
                NLPLogix.WindowSizeX = 600;
                NLPLogix.WindowSizeY = 960;
            }
            else if(Device.Equals("Nokia Lumia 520"))
            {
                NLPLogix.Browser = "Edge";
                NLPLogix.WindowSizeX = 320;
                NLPLogix.WindowSizeY = 533;
            }
            else if(Device.Equals("Nokia N9"))
            {
                NLPLogix.Browser = "Edge";
                NLPLogix.WindowSizeX = 480;
                NLPLogix.WindowSizeY = 854;
            }
            else if(Device.Equals("Pixel 3") || Device.Equals("Pixel 3 XL"))
            {
                NLPLogix.Browser = "Chrome";
                NLPLogix.WindowSizeX = 393;
                NLPLogix.WindowSizeY = 786;
            }
            else if(Device.Equals("Pixel 4"))
            {
                NLPLogix.Browser = "Chrome";
                NLPLogix.WindowSizeX = 353;
                NLPLogix.WindowSizeY = 745;
            }
            else if(Device.Equals("iPhone 4"))
            {
                NLPLogix.Browser = "Safari";
                NLPLogix.WindowSizeX = 320;
                NLPLogix.WindowSizeY = 480;
            }
            else if(Device.Equals("JioPhone"))
            {
                NLPLogix.Browser = "Chrome";
                NLPLogix.WindowSizeX = 240;
                NLPLogix.WindowSizeY = 320;
            }
            else if(Device.Equals("iPhone SE") || Device.Equals("iPhone 6/7/8"))
            {
                NLPLogix.Browser = "Safari";
                NLPLogix.WindowSizeX = 375;
                NLPLogix.WindowSizeY = 667;
            }
            else if(Device.Equals("iPhone XR"))
            {
                NLPLogix.Browser = "Safari";
                NLPLogix.WindowSizeX = 414;
                NLPLogix.WindowSizeY = 896;
            }
            else if(Device.Equals("iPhone 12"))
            {
                NLPLogix.Browser = "Safari";
                NLPLogix.WindowSizeX = 390;
                NLPLogix.WindowSizeY = 844;
            }
            else if(Device.Equals("Pixel 5"))
            {
                NLPLogix.Browser = "Chrome";
                NLPLogix.WindowSizeX = 393;
                NLPLogix.WindowSizeY = 815;
            }
            else if(Device.Equals("iPad Air"))
            {
                NLPLogix.Browser = "Safari";
                NLPLogix.WindowSizeX = 1140;
                NLPLogix.WindowSizeY = 820;
            }
            else if(Device.Equals("iPad Mini") || Device.Equals("iPad"))
            {
                NLPLogix.Browser = "Safari";
                NLPLogix.WindowSizeX = 1024;
                NLPLogix.WindowSizeY = 768;
            }
            else if(Device.Equals("Surface Pro 7"))
            {
                NLPLogix.Browser = "Edge";
                NLPLogix.WindowSizeX = 1386;
                NLPLogix.WindowSizeY = 912;
            }
            else if(Device.Equals("Surface Duo"))
            {
                NLPLogix.Browser = "Edge";
                NLPLogix.WindowSizeX = 540;
                NLPLogix.WindowSizeY = 720;
            }
            else if(Device.Equals("Samsung Galaxy A51/71"))
            {
                NLPLogix.Browser = "Chrome";
                NLPLogix.WindowSizeX = 412;
                NLPLogix.WindowSizeY = 914;
            }
            else if(Device.Equals("Pixel 2"))
            {
                NLPLogix.Browser = "Chrome";
                NLPLogix.WindowSizeX = 411;
                NLPLogix.WindowSizeY = 713;
            }
            else if(Device.Equals("Pixel 2 XL"))
            {
                NLPLogix.Browser = "Chrome";
                NLPLogix.WindowSizeX = 411;
                NLPLogix.WindowSizeY = 823;
            }
            else if(Device.Equals("iPhone 5/SE"))
            {
                NLPLogix.Browser = "Safari";
                NLPLogix.WindowSizeX = 320;
                NLPLogix.WindowSizeY = 568;
            }
            else if(Device.Equals("iPhone 6/7/8 Plus"))
            {
                NLPLogix.Browser = "Safari";
                NLPLogix.WindowSizeX = 414;
                NLPLogix.WindowSizeY = 736;
            }
            else if(Device.Equals("iPhone X"))
            {
                NLPLogix.Browser = "Safari";
                NLPLogix.WindowSizeX = 375;
                NLPLogix.WindowSizeY = 812;
            }
            else if(Device.Equals("iPad Pro"))
            {
                NLPLogix.Browser = "Safari";
                NLPLogix.WindowSizeX = 1366;
                NLPLogix.WindowSizeY = 1024;
            }
            else
            {
                NLPLogix.Browser = "Chrome";
                NLPLogix.WindowSizeX = 1280;
                NLPLogix.WindowSizeY = 1280;
            }

            NLPLogix.Language = langName.Generate();
            NLPLogix.Headless = headless;
        }
    }
}
