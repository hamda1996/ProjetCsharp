
using System.Collections.Generic;

namespace FilRougeApi.Models
{

    public class Personne
    {
        public long PersonneID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public ICollection<Formation> Formations { get; set; }

    }
}
