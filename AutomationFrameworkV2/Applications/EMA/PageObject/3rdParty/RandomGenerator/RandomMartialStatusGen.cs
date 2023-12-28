using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using ServiceStack.FluentValidation.Resources;

namespace RandomMartialStatusGen
{
    public class RandomMartialStatus
    {
     
        class RandomList
        {
            public string[] martialstatus { get; set; }
            public string[] martialstatustranslated { get; set; }

            public RandomList()
            {
                martialstatus = new string[] { };
                martialstatustranslated = new string[] { };
            }
        }

        Random rand;
        List<string> Martial;

        public RandomMartialStatus(Random rand, string language)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("martialstatus.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }

            if(language.Equals("English"))
            {
                Martial = new List<string>(l.martialstatus);
            }
            else
            {
                Martial = new List<string>(l.martialstatustranslated);
            }
        }

        public string Generate()
        {
            string ms = Martial[rand.Next(Martial.Count)]; // gets the Device

            StringBuilder b = new StringBuilder();
            b.Append(ms);

            return b.ToString();
        }
    }

}