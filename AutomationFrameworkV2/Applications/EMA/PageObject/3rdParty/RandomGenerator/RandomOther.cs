using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace OtherGen
{
    public class RandomOther
    {
     
        class RandomList
        {
            public string[] other { get; set; }

            public RandomList()
            {
                other = new string[] { };
            }
        }

        Random rand;
        List<string> Other;

        public RandomOther(Random rand)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("other.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }
            Other = new List<string>(l.other);
        }

        public string Generate()
        {
            string eth = Other[rand.Next(Other.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(eth);

            return b.ToString();
        }
    }

}