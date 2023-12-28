using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace AdditionalIncomeGen
{
    public class RandomAdditionalIncome
    {
     
        class RandomList
        {
            public string[] additionalincome { get; set; }

            public RandomList()
            {
                additionalincome = new string[] { };
            }
        }

        Random rand;
        List<string> AdditionalIncome;

        public RandomAdditionalIncome(Random rand)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("AdditionalIncome.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }
            AdditionalIncome = new List<string>(l.additionalincome);
        }

        public string Generate()
        {
            string eth = AdditionalIncome[rand.Next(AdditionalIncome.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(eth);

            return b.ToString();
        }
    }

}