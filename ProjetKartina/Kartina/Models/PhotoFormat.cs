using System;
using System.Collections.Generic;

namespace Kartina.Models
{
    public partial class PhotoFormat
    {
        public int IdPhoto { get; set; }
        public int IdFormat { get; set; }

        public Format IdFormatNavigation { get; set; }
        public Photo IdPhotoNavigation { get; set; }
    }
}
