using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using ServiceStack.FluentValidation.Resources;

namespace RandomRelationshipToYouGen
{
    public class RandomRelationshipToYou
    {
     
        class RandomList
        {
            public string[] relationship { get; set; }
            public string[] relationshiptranslated { get; set; }

            public RandomList()
            {
                relationship = new string[] { };
                relationshiptranslated = new string[] { };
            }
        }

        Random rand;
        List<string> RelationshipToYou;

        public RandomRelationshipToYou(Random rand, string language)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("relationshiptoyou.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }

            if(language.Equals("English"))
            {
                RelationshipToYou = new List<string>(l.relationship);
            }
            else
            {
                RelationshipToYou = new List<string>(l.relationshiptranslated);
            }
        }

        public string Generate()
        {
            string rty = RelationshipToYou[rand.Next(RelationshipToYou.Count)]; // gets the Device

            StringBuilder b = new StringBuilder();
            b.Append(rty);

            return b.ToString();
        }
    }

}