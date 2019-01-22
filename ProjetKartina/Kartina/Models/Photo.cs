using System;
using System.Collections.Generic;

namespace Kartina.Models
{
    public partial class Photo
    {
        public Photo()
        {
            LigneCommande = new HashSet<LigneCommande>();
            PhotoFormat = new HashSet<PhotoFormat>();
            ThemePhoto = new HashSet<ThemePhoto>();
        }

        public int IdPhoto { get; set; }
        public int? IdFormat { get; set; }
        public int? IdTheme { get; set; }
        public string TitrePhoto { get; set; }
        public string DescriptionPhoto { get; set; }
        public double PrixPhoto { get; set; }
        public double LargeurPhoto { get; set; }
        public double HauteurPhoto { get; set; }
        public int IdUtilisateur { get; set; }
        public int? IdOrientation { get; set; }
        public DateTime DateDepose { get; set; }

        public Orientation IdOrientationNavigation { get; set; }
        public Utilisateur IdUtilisateurNavigation { get; set; }
        public ICollection<LigneCommande> LigneCommande { get; set; }
        public ICollection<PhotoFormat> PhotoFormat { get; set; }
        public ICollection<ThemePhoto> ThemePhoto { get; set; }
    }
}
