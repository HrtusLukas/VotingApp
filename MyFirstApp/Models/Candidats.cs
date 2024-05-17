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

        [JsonPropertyName("pocetHlavsov")] public int TotalVotes { get; set; }

        [JsonPropertyName("detail")] public Detail KandiatDetail { get; set; }



    }

    public class Detail
    {
        [JsonPropertyName("narodenie")]
        public string? BirthDate { get; set; }

        [JsonPropertyName("info")]
        public string? Info { get; set; }

        //imagePath


        [JsonPropertyName("imagePath")]
        public string ImagePath { get; set; }

    }

}
