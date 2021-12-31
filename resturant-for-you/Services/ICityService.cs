using Gremlin.Net.Structure;
using LaYumba.Functional;
using resturant_for_you.Domain;
using System.Collections.Generic;

namespace resturant_for_you.Services
{
    public interface ICityService
    {
        public Option<List<City>> GetAllCities();

        public Option<Vertex> GetVertexForACity(City city);
    }
}
