﻿using System;
using System.Collections.Generic;

namespace Game.Data.Models
{
    public partial class GameTypes
    {
        public int GameTypeId { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public DateTime Registration { get; set; }
        public DateTime? Modification { get; set; }
    }
}
