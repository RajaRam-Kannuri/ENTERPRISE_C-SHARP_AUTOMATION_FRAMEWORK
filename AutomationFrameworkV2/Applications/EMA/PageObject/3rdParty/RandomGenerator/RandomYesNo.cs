using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using org.omg.CORBA;

namespace RandomYesNoAns
{
    public class RandomYesNo
    {
     
        class RandomList
        {
            public string[] yesno { get; set; }
            public string[] yesnotranslated { get; set; }

            public RandomList()
            {
                yesno = new string[] { };
                yesnotranslated = new string[] { };
            }
        }

        Random rand;
        List<string> Answer;

        public RandomYesNo(Random rand, string language)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("answers.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }
            if (language.Equals("English"))
            {
                Answer = new List<string>(l.yesno);
            } else
            {
                Answer = new List<string>(l.yesnotranslated);
            }
        }

        public string Generate()
        {
            string ans = Answer[rand.Next(Answer.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(ans);
            
            return b.ToString();
        }
    }

}