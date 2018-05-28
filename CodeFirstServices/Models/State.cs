using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstServices.Models
{
    public class State
    {
        [Key]
        public int StateId { get; set; }
        public string Name { get; set; }
        public List<City> Cites { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}