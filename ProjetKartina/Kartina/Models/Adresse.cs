using System;
using System.Collections.Generic;

namespace Kartina.Models
{
    public partial class Adresse
    {
        public Adresse()
        {
            Utilisateur = new HashSet<Utilisateur>();
        }

        public int IdAdresse { get; set; }
        public string Rue { get; set; }
        public int? CodePostal { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public string TypeAdresse { get; set; }

        public ICollection<Utilisateur> Utilisateur { get; set; }
    }
}
