using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace UnemploymentAndRelatedGen
{
    public class RandomUnemploymentAndRelated
    {
     
        class RandomList
        {
            public string[] unemployment { get; set; }

            public RandomList()
            {
                unemployment = new string[] { };
            }
        }

        Random rand;
        List<string> UnemploymentAndRelated;

        public RandomUnemploymentAndRelated(Random rand)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("unemploymentandrelated.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }
            UnemploymentAndRelated = new List<string>(l.unemployment);
        }

        public string Generate()
        {
            string eth = UnemploymentAndRelated[rand.Next(UnemploymentAndRelated.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(eth);

            return b.ToString();
        }
    }

}