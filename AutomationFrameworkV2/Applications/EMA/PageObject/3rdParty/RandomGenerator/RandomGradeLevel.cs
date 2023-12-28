using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace GradeLevelGen
{
    public class RandomGradeLevel
    {
     
        class RandomList
        {
            public string[] gradelevel { get; set; }

            public RandomList()
            {
                gradelevel = new string[] { };
            }
        }

        Random rand;
        List<string> GradeLevel;

        public RandomGradeLevel(Random rand)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("gradelevel.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }
            GradeLevel = new List<string>(l.gradelevel);
        }

        public string Generate()
        {
            string eth = GradeLevel[rand.Next(GradeLevel.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(eth);

            return b.ToString();
        }
    }

}