using System;
using System.Collections.Generic;

namespace Kartina.Models
{
    public partial class Finition
    {
        public Finition()
        {
            CadreFinition = new HashSet<CadreFinition>();
            FormatFinition = new HashSet<FormatFinition>();
            LigneCommande = new HashSet<LigneCommande>();
        }

        public int IdFinition { get; set; }
        public string NomFinition { get; set; }

        public ICollection<CadreFinition> CadreFinition { get; set; }
        public ICollection<FormatFinition> FormatFinition { get; set; }
        public ICollection<LigneCommande> LigneCommande { get; set; }
    }
}
