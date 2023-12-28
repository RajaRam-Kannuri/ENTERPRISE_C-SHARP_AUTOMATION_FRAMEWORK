using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace EthnicityGen
{
    public class RandomEthnicity
    {
     
        class RandomList
        {
            public string[] ethnicity { get; set; }
            public string[] ethnicitytranslated { get; set; }

            public RandomList()
            {
                ethnicity = new string[] { };
                ethnicitytranslated = new string[] { };
            }
        }

        Random rand;
        List<string> Ethnicity;

        public RandomEthnicity(Random rand, string language)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("ethnicity.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }
            if (language.Equals("English"))
            {
                Ethnicity = new List<string>(l.ethnicity);
            } else
            {
                Ethnicity = new List<string>(l.ethnicitytranslated);
            }
        }

        public string Generate()
        {
            string eth = Ethnicity[rand.Next(Ethnicity.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(eth);

            return b.ToString();
        }
    }

}