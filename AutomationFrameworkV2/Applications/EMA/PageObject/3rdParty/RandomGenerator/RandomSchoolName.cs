using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace RandomSchoolNameAns
{
    public class RandomSchoolName
    {
     
        class RandomList
        {
            public string[] schoolname { get; set; }

            public RandomList()
            {
                schoolname = new string[] { };
            }
        }

        Random rand;
        List<string> SchoolName;

        public RandomSchoolName(Random rand)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("schoolname.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }
            SchoolName = new List<string>(l.schoolname);
        }

        public string Generate()
        {
            string ans = SchoolName[rand.Next(SchoolName.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(ans);
            
            return b.ToString();
        }
    }

}