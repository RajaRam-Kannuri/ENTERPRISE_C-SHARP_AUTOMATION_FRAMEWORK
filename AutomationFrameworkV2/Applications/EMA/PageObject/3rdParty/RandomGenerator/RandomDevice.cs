using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace RandomDeviceGen
{
    public class RandomDev
    {
     
        class RandomList
        {
            public string[] device { get; set; }

            public RandomList()
            {
                device = new string[] { };
            }
        }

        Random rand;
        List<string> Device;

        public RandomDev(Random rand)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("devices.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }

            Device = new List<string>(l.device);
        }

        public string Generate()
        {
            string lang = Device[rand.Next(Device.Count)]; // gets the Device

            StringBuilder b = new StringBuilder();
            b.Append(lang);

            return b.ToString();
        }
    }

}