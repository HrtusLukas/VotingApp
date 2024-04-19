using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyFirstApp.Models
{
    public class Candidats
    {
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("strana")] public string? PoliticalParty { get; set; }
        private int TotalVotes { get; set; }

        public Candidats(string name, string? politicalparty) 
        {
            Name = name;
            PoliticalParty = politicalparty;
        }

    }
}

