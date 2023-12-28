using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace RandomIHaveAAns
{
    public class RandomIHaveA
    {
     
        class RandomList
        {
            public string[] ihavea { get; set; }

            public RandomList()
            {
                ihavea = new string[] { };
            }
        }

        Random rand;
        List<string> IHaveA;

        public RandomIHaveA(Random rand)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("IHaveA.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }
            IHaveA = new List<string>(l.ihavea);
        }

        public string Generate()
        {
            string ans = IHaveA[rand.Next(IHaveA.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(ans);
            
            return b.ToString();
        }
    }

}