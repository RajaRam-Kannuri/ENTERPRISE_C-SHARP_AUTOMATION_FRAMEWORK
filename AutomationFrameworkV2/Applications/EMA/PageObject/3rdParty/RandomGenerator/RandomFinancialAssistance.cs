using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace FinancialAssistanceGen
{
    public class RandomFinancialAssistance
    {
     
        class RandomList
        {
            public string[] financialassistance { get; set; }

            public RandomList()
            {
                financialassistance = new string[] { };
            }
        }

        Random rand;
        List<string> FinancialAssistance;

        public RandomFinancialAssistance(Random rand)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("financialassistance.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }
            FinancialAssistance = new List<string>(l.financialassistance);
        }

        public string Generate()
        {
            string eth = FinancialAssistance[rand.Next(FinancialAssistance.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(eth);

            return b.ToString();
        }
    }

}