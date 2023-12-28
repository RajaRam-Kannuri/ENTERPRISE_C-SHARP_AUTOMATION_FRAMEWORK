using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace PhoneType
{
    public class RandomPhone
    {
     
        class RandomList
        {
            public string[] phonetype { get; set; }

            public RandomList()
            {
                phonetype = new string[] { };
            }
        }

        Random rand;
        List<string> PhoneTypeList;

        public RandomPhone(Random rand)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("phonetype.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }

            PhoneTypeList = new List<string>(l.phonetype);
        }

        public string Generate()
        {
            string ptl = PhoneTypeList[rand.Next(PhoneTypeList.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(ptl);
            
            return b.ToString();
        }
    }

}