using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstServices.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        public string Name { get; set; }
        public List<State> States { get; set; }

    }
}