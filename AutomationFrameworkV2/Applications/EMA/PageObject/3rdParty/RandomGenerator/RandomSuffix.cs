using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace SuffixGen
{
    public class RandomSuffix
    {
     
        class RandomList
        {
            public string[] suffix { get; set; }

            public RandomList()
            {
                suffix = new string[] { };
            }
        }

        Random rand;
        List<string> Suffix;

        public RandomSuffix(Random rand)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("suffix.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }

            Suffix = new List<string>(l.suffix);
        }

        public string Generate()
        {
            string suf = Suffix[rand.Next(Suffix.Count)]; // gets the Device

            StringBuilder b = new StringBuilder();
            b.Append(suf);

            return b.ToString();
        }
    }

}