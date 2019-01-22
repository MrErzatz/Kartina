using System;
using System.Collections.Generic;

namespace Kartina.Models
{
    public partial class Theme
    {
        public Theme()
        {
            ThemePhoto = new HashSet<ThemePhoto>();
        }

        public int IdTheme { get; set; }
        public string TitreTheme { get; set; }

        public ICollection<ThemePhoto> ThemePhoto { get; set; }
    }
}
