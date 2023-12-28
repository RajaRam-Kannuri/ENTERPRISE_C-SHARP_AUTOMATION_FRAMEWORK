using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace RandomTypeofSchoolAns
{
    public class RandomTypeofSchoolExpected
    {
     
        class RandomList
        {
            public string[] schooltype { get; set; }

            public RandomList()
            {
                schooltype = new string[] { };
            }
        }

        Random rand;
        List<string> TypeofSchool;

        public RandomTypeofSchoolExpected(Random rand)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("typeofschoolexpected.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }
            TypeofSchool = new List<string>(l.schooltype);
        }

        public string Generate()
        {
            string ans = TypeofSchool[rand.Next(TypeofSchool.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(ans);
            
            return b.ToString();
        }
    }

}