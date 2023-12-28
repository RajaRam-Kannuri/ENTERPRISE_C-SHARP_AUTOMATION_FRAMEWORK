using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace RandomFLAddress
{
    public class RandomFLAddresses
    {
     
        class RandomList
        {
            public string[] zip { get; set; }
            public string[] zipcodename { get; set; }
            public string[] city { get; set; }
            public string[] state { get; set; }
            public string[] countyname { get; set; }

            public RandomList()
            {
                zip = new string[] { };
                zipcodename = new string[] { };
                city = new string[] { };
                state = new string[] { };
                countyname = new string[] { };
            }
        }

        Random rand;
        List<string> ZIP;
        List<string> ZIPCodeName;
        List<string> City;
        List<string> State;
        List<string> CountyName;


        public RandomFLAddresses(Random rand)
        {
            this.rand = rand;
            RandomList l = new RandomList();

            JsonSerializer serializer = new JsonSerializer();

            using(StreamReader reader = new StreamReader("fladdress.json"))
            using(JsonReader jreader = new JsonTextReader(reader))
            {
                l = serializer.Deserialize<RandomList>(jreader);
            }

            ZIP = new List<string>(l.zip);
            ZIPCodeName = new List<string>(l.zipcodename);
            City = new List<string>(l.city);
            State = new List<string>(l.state);
            CountyName = new List<string>(l.countyname);
        }

        public string GenerateZIP()
        {
            string flzips = ZIP[rand.Next(ZIP.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(flzips);

            return b.ToString();
        }

        public string GenerateZIPCodeName()
        {
            string flzipcodename = ZIPCodeName[rand.Next(ZIPCodeName.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(flzipcodename);

            return b.ToString();
        }

        public string GenerateCity()
        {
            string flcity = City[rand.Next(City.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(flcity);

            return b.ToString();
        }

        public string GenerateState()
        {
            string flstate = State[rand.Next(State.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(flstate);

            return b.ToString();
        }


        public string GenerateCounty()
        {
            string flcountyname = CountyName[rand.Next(CountyName.Count)];

            StringBuilder b = new StringBuilder();
            b.Append(flcountyname);

            return b.ToString();
        }

    }
}