using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace RandomPaidHowOftenAns
{
    public class RandomPaidHowOften
    {
     
        class RandomList
        {
            public string[] payfrequency { get; set; }

            public RandomList()
            {
                payfrequency = new string[] { };
            }
        }

        Random rand;
        List<string> PaidHowOften;

        public RandomPaidHowOften(Random rand)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("paidhowoften.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }
            PaidHowOften = new List<string>(l.payfrequency);
        }

        public string Generate()
        {
            string ans = PaidHowOften[rand.Next(PaidHowOften.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(ans);
            
            return b.ToString();
        }
    }

}