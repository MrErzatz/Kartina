using System;
using System.Collections.Generic;

namespace Kartina.Models
{
    public partial class Cadre
    {
        public Cadre()
        {
            CadreFinition = new HashSet<CadreFinition>();
            LigneCommande = new HashSet<LigneCommande>();
        }

        public int IdCadre { get; set; }
        public string NomCadre { get; set; }

        public ICollection<CadreFinition> CadreFinition { get; set; }
        public ICollection<LigneCommande> LigneCommande { get; set; }
    }
}
