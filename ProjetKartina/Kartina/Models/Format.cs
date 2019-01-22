using System;
using System.Collections.Generic;

namespace Kartina.Models
{
    public partial class Format
    {
        public Format()
        {
            FormatFinition = new HashSet<FormatFinition>();
            LigneCommande = new HashSet<LigneCommande>();
            PhotoFormat = new HashSet<PhotoFormat>();
        }

        public int IdFormat { get; set; }
        public string NomFormat { get; set; }

        public ICollection<FormatFinition> FormatFinition { get; set; }
        public ICollection<LigneCommande> LigneCommande { get; set; }
        public ICollection<PhotoFormat> PhotoFormat { get; set; }
    }
}
