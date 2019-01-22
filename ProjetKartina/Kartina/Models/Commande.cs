using System;
using System.Collections.Generic;

namespace Kartina.Models
{
    public partial class Commande
    {
        public Commande()
        {
            LigneCommande = new HashSet<LigneCommande>();
        }

        public int IdCommande { get; set; }
        public int NumeroCommande { get; set; }
        public DateTime DateCommande { get; set; }
        public double PrixCommande { get; set; }
        public string StatutCommande { get; set; }
        public int IdUtilisateur { get; set; }
        public int? IdStatut { get; set; }

        public Statut IdStatutNavigation { get; set; }
        public ICollection<LigneCommande> LigneCommande { get; set; }
    }
}
