using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilRougeApi.Models
{
    public class Formation
    {
        
        public long FormationID { get; set; }
        public long PersonneID { get; set; }
        public string Titre { get; set; }
        public int Duree { get; set; }
        public DateTime Date_Deb { get; set; }
        public Personne Personne { get; set; }




    }
}
