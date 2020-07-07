using System;
using System.Collections.Generic;

namespace Game.Data.Models
{
    public partial class Series
    {
        public int SerieId { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public string SerieTypes { get; set; }
        public string Starring { get; set; }
        public string DistributedBy { get; set; }
        public decimal? Duration { get; set; }
        public int? NoSeasons { get; set; }
        public int? NoEpisodes { get; set; }
        public int? CountryId { get; set; }
        public string Lenguages { get; set; }
        public string Subtitles { get; set; }
        public DateTime? Release { get; set; }
        public string Image { get; set; }
        public bool? IsActive { get; set; }
        public DateTime Registration { get; set; }
        public DateTime? Modification { get; set; }
        public long RegiUser { get; set; }

        public virtual Countries Country { get; set; }
    }
}
