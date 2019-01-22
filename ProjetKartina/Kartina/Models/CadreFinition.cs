using System;
using System.Collections.Generic;

namespace Kartina.Models
{
    public partial class CadreFinition
    {
        public int IdCadre { get; set; }
        public int IdFinition { get; set; }

        public Cadre IdCadreNavigation { get; set; }
        public Finition IdFinitionNavigation { get; set; }
    }
}
