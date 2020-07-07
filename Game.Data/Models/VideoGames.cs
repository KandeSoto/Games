using System;
using System.Collections.Generic;

namespace Game.Data.Models
{
    public partial class VideoGames
    {
        public int VideoGameId { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public string GameTypes { get; set; }
        public string Platforms { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public string GameModes { get; set; }
        public bool? IsOnline { get; set; }
        public DateTime? Release { get; set; }
        public decimal? GameHours { get; set; }
        public string Image { get; set; }
        public string Lenguages { get; set; }
        public bool? IsActive { get; set; }
        public DateTime Registration { get; set; }
        public DateTime? Modification { get; set; }
        public long RegiUser { get; set; }
    }
}
