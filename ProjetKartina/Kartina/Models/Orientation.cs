using System;
using System.Collections.Generic;

namespace Kartina.Models
{
    public partial class Orientation
    {
        public Orientation()
        {
            Photo = new HashSet<Photo>();
        }

        public int IdOrientation { get; set; }
        public string NomOrientation { get; set; }

        public ICollection<Photo> Photo { get; set; }
    }
}
