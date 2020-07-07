using System;
using System.Collections.Generic;

namespace Game.Data.Models
{
    public partial class Users
    {
        public long UserId { get; set; }
        public long PersonId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool? IsActive { get; set; }
        public DateTime Registration { get; set; }
        public DateTime? Modification { get; set; }
        public DateTime? IsAdmin { get; set; }

        public virtual Persons Person { get; set; }
    }
}
