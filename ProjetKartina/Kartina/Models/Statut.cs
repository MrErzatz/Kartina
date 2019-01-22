using System;
using System.Collections.Generic;

namespace Kartina.Models
{
    public partial class Statut
    {
        public Statut()
        {
            Commande = new HashSet<Commande>();
        }

        public int IdStatut { get; set; }
        public string NomStatut { get; set; }

        public ICollection<Commande> Commande { get; set; }
    }
}
