using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace GradeLevelGen
{
    public class RandomPaidType
    {
     
        class RandomList
        {
            public string[] paidtype { get; set; }

            public RandomList()
            {
                paidtype = new string[] { };
            }
        }

        Random rand;
        List<string> PaidType;

        public RandomPaidType(Random rand)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("paidtype.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }
            PaidType = new List<string>(l.paidtype);
        }

        public string Generate()
        {
            string eth = PaidType[rand.Next(PaidType.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(eth);

            return b.ToString();
        }
    }

}