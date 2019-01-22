using System;
using System.Collections.Generic;

namespace Kartina.Models
{
    public partial class ThemePhoto
    {
        public int IdPhoto { get; set; }
        public int IdTheme { get; set; }

        public Photo IdPhotoNavigation { get; set; }
        public Theme IdThemeNavigation { get; set; }
    }
}
