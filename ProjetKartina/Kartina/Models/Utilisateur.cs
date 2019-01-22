using System;
using System.Collections.Generic;

namespace Kartina.Models
{
    public partial class Utilisateur
    {
        public Utilisateur()
        {
            Photo = new HashSet<Photo>();
        }

        public int IdUtilisateur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string MotPass { get; set; }
        public string Civilité { get; set; }
        public string Telephone { get; set; }
        public int? IdProfilUtilisateur { get; set; }
        public int IdAdresse { get; set; }

        public Adresse IdAdresseNavigation { get; set; }
        public ProfilUtilisateur IdProfilUtilisateurNavigation { get; set; }
        public ICollection<Photo> Photo { get; set; }
    }
}
