using System;
using System.ComponentModel.DataAnnotations;

namespace Game.Data.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        [Required]
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string Active => IsActive ? "Active" : "Inactive";
        public DateTime Registration { get; set; }
        public DateTime? Modification { get; set; }
    }
}