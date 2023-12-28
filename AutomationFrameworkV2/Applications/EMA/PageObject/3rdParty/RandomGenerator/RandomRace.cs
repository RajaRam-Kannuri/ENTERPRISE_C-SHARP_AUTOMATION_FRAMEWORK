using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace RandomRaceGen
{
    public class RandomRace
    {
     
        class RandomList
        {
            public string[] race { get; set; }
            public string[] racetranslated { get; set; }

            public RandomList()
            {
                race = new string[] { };
                racetranslated = new string[] { };
            }
        }

        Random rand;
        List<string> Race;

        public RandomRace(Random rand, string language)
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
                Race = new List<string>(l.race);
            }
            else
            {
                Race = new List<string>(l.racetranslated);
            }
        }

        public string Generate()
        {
            string rty = Race[rand.Next(Race.Count)]; // gets the Device

            StringBuilder b = new StringBuilder();
            b.Append(rty);

            return b.ToString();
        }
    }

}