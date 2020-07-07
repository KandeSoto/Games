using System;
using System.Collections.Generic;

namespace Game.Data.Models
{
    public partial class Persons
    {
        public Persons()
        {
            Users = new HashSet<Users>();
        }

        public long PersonId { get; set; }
        public int? CountryId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Registration { get; set; }
        public DateTime? Modification { get; set; }

        public virtual Countries Country { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
