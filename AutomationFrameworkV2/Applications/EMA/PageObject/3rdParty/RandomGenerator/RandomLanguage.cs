using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace RandomLanguageGen
{
    /// <summary>
    /// RandomLanguage class, used to generate a random Language.
    /// </summary>
    public class RandomLang
    {
        /// <summary>
        /// Class for holding the lists of names from languages.json
        /// </summary>
        class RandomList
        {
            public string[] language { get; set; }

            public RandomList()
            {
                language = new string[] { };
            }
        }

        Random rand;
        List<string> Language;

        /// <summary>
        /// Initialises a new instance of the RandomLanguage class.
        /// </summary>
        /// <param name="rand">A Random that is used to pick Language</param>
        public RandomLang(Random rand)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("languages.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }

            Language = new List<string>(l.language);
        }

        /// <summary>
        /// Returns a new random language
        /// </summary>
        public string Generate()
        {
            string lang = Language[rand.Next(Language.Count)]; // gets the Language

            StringBuilder b = new StringBuilder();
            b.Append(lang);

            return b.ToString();
        }
    }

}