using System;
using System.Collections.Generic;

namespace Kartina.Models
{
    public partial class ProfilUtilisateur
    {
        public ProfilUtilisateur()
        {
            Utilisateur = new HashSet<Utilisateur>();
        }

        public int IdProfilUtilisateur { get; set; }
        public string TypeProfil { get; set; }

        public ICollection<Utilisateur> Utilisateur { get; set; }
    }
}
