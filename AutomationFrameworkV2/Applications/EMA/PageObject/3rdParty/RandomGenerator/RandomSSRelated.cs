using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace SocialSecurityRelatedGen
{
    public class RandomSocialSecurityRelated
    {
     
        class RandomList
        {
            public string[] socialsecurityrelated { get; set; }

            public RandomList()
            {
                socialsecurityrelated = new string[] { };
            }
        }

        Random rand;
        List<string> SocialSecurityRelated;

        public RandomSocialSecurityRelated(Random rand)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("ssrelated.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }
            SocialSecurityRelated = new List<string>(l.socialsecurityrelated);
        }

        public string Generate()
        {
            string eth = SocialSecurityRelated[rand.Next(SocialSecurityRelated.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(eth);

            return b.ToString();
        }
    }

}