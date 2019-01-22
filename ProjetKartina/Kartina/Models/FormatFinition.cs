using System;
using System.Collections.Generic;

namespace Kartina.Models
{
    public partial class FormatFinition
    {
        public int IdFormat { get; set; }
        public int IdFinition { get; set; }

        public Finition IdFinitionNavigation { get; set; }
        public Format IdFormatNavigation { get; set; }
    }
}
