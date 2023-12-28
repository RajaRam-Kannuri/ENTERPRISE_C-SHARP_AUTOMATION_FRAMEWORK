using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace RandomIncomeVerificationDocumentAns
{
    public class RandomIncomeVerificationDocument
    {
     
        class RandomList
        {
            public string[] incomeverificationdocument { get; set; }

            public RandomList()
            {
                incomeverificationdocument = new string[] { };
            }
        }

        Random rand;
        List<string> IncomeVerificationDocument;

        public RandomIncomeVerificationDocument(Random rand)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("incomeverificationdocument.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }
            IncomeVerificationDocument = new List<string>(l.incomeverificationdocument);
        }

        public string Generate()
        {
            string ans = IncomeVerificationDocument[rand.Next(IncomeVerificationDocument.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(ans);
            
            return b.ToString();
        }
    }

}