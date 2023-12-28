using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace RandomSchoolCountyAns
{
    public class RandomSchoolCounty
    {
     
        class RandomList
        {
            public string[] schoolcounty { get; set; }

            public RandomList()
            {
                schoolcounty = new string[] { };
            }
        }

        Random rand;
        List<string> SchoolCounty;

        public RandomSchoolCounty(Random rand)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("schoolcounty.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }
            SchoolCounty = new List<string>(l.schoolcounty);
        }

        public string Generate()
        {
            string ans = SchoolCounty[rand.Next(SchoolCounty.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(ans);
            
            return b.ToString();
        }
    }

}