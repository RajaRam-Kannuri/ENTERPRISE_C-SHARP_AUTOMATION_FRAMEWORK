using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace RandomEmploymentTypeAns
{
    public class RandomEmploymentType
    {
     
        class RandomList
        {
            public string[] employmenttype { get; set; }

            public RandomList()
            {
                employmenttype = new string[] { };
            }
        }

        Random rand;
        List<string> EmploymentType;

        public RandomEmploymentType(Random rand)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("employmenttype.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }
            EmploymentType = new List<string>(l.employmenttype);
        }

        public string Generate()
        {
            string ans = EmploymentType[rand.Next(EmploymentType.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(ans);
            
            return b.ToString();
        }
    }

}