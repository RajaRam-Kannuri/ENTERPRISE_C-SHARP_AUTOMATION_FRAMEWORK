using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace RandomGuardianProofOfResidencyAns
{
    public class RandomGuardianProofOfResidency
    {
     
        class RandomList
        {
            public string[] proofofresidency { get; set; }

            public RandomList()
            {
                proofofresidency = new string[] { };
            }
        }

        Random rand;
        List<string> GuardianProofOfResidency;

        public RandomGuardianProofOfResidency(Random rand)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("guardianproofofresidency.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }
            GuardianProofOfResidency = new List<string>(l.proofofresidency);
        }

        public string Generate()
        {
            string ans = GuardianProofOfResidency[rand.Next(GuardianProofOfResidency.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(ans);
            
            return b.ToString();
        }
    }

}