using System;
using System.Collections.Generic;

namespace Kartina.Models
{
    public partial class LigneCommande
    {
        public int IdPhoto { get; set; }
        public int IdCommande { get; set; }
        public int IdFormat { get; set; }
        public int IdFinition { get; set; }
        public int IdCadre { get; set; }
        public int Quantite { get; set; }
        public double Prix { get; set; }

        public Cadre IdCadreNavigation { get; set; }
        public Commande IdCommandeNavigation { get; set; }
        public Finition IdFinitionNavigation { get; set; }
        public Format IdFormatNavigation { get; set; }
        public Photo IdPhotoNavigation { get; set; }
    }
}
