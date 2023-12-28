using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace FamilyGen
{
    public class RandomFamily
    {
     
        class RandomList
        {
            public string[] family { get; set; }

            public RandomList()
            {
                family = new string[] { };
            }
        }

        Random rand;
        List<string> Family;

        public RandomFamily(Random rand)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("family.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }
            Family = new List<string>(l.family);
        }

        public string Generate()
        {
            string eth = Family[rand.Next(Family.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(eth);

            return b.ToString();
        }
    }

}