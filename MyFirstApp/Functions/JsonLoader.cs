using MyFirstApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.Functions
{

    
    public static class JsonLoader
    {
        public static List<Candidats> LoadCandidatesFromJson(string path)
        {
            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<Candidats>>(json);
        }
    }

}
