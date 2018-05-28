using CodeFirstServices.Models;
using CodeFirstServices.Models.Context;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CodeFirstServices.Controllers
{
    public class DefaultController : ApiController
    {
        public IHttpActionResult Get()
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                     var result = db.Countries.ToList();
                                        
                    //var result = from country in db.Countries
                    //              select new
                    //              {
                    //                  country.CountryId,
                    //                  country.Name,
                    //                  State = from state in db.States
                    //                          where state.CountryId == country.CountryId
                    //                          select new
                    //                          {
                    //                              state.StateId,
                    //                              state.Name,
                    //                              City= from city in db.cities
                    //                                    where city.StateId == state.StateId
                    //                                    select new
                    //                                    {
                    //                                        city.CityId,
                    //                                        city.Name                                                            
                    //                                    }
                    //                          }
                    //              };
                    if (result != null)
                    {
                        return Ok(result);
                    }
                    else
                    {
                        return NotFound();
                    }
                }            

            }catch (Exception ex)
            {
                return InternalServerError();
            }
        }
        
    }
}
