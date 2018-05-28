using System.Collections.Generic;
using System.Data.Entity;
using System.Configuration;

namespace CodeFirstServices.Models.Context
{
    public class DatabaseInitializer: DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);
            var cityInMaharashtra = new List<City>
            {
                new City{ Name = "Mumbai"},
                new City{Name= "Pune"}
            };
            var cityInUttarPradesh = new List<City> {
                new City {Name="Lucknow" },
                new City {Name="Banaras" }
            };
            var cityInTamilnadu = new List<City> {
                new City {Name="Mysore" },
                new City {Name="Chennai" }
            };
            var cityInUttaranchal = new List<City> {
                new City {Name="Dehradun" },
                new City {Name="Rishikesh" }
            };
            var cityInPanjab = new List<City> {
                new City {Name="Patiyala" },
                new City {Name="Ludhiana" }
            };
            var statesInIndia = new List<State>
            {
                new State { Name="UP", Cites=cityInUttarPradesh},
                new State { Name="Maharashtra", Cites=cityInMaharashtra}
            };
            Country country = new Country()
            {
                 Name="India",
                 States= statesInIndia
            };

            context.Countries.Add(country);
            context.SaveChanges();

        }

    }
}