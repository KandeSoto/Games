using System;
using System.Collections.Generic;

namespace Game.Data.Models
{
    public partial class Platforms
    {
        public int PlatformId { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public DateTime Registration { get; set; }
        public DateTime? Modification { get; set; }
    }
}
