using System;
using System.Collections.Generic;

namespace Game.Data.Models
{
    public partial class Countries
    {
        public Countries()
        {
            Films = new HashSet<Films>();
            Persons = new HashSet<Persons>();
            Series = new HashSet<Series>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public DateTime Registration { get; set; }
        public DateTime? Modification { get; set; }

        public virtual ICollection<Films> Films { get; set; }
        public virtual ICollection<Persons> Persons { get; set; }
        public virtual ICollection<Series> Series { get; set; }
    }
}
