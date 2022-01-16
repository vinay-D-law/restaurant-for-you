using Gremlin.Net.Process.Traversal;
using Gremlin.Net.Structure;
using LaYumba.Functional;
using Newtonsoft.Json;
using restaurant_for_you.Domain;
using restaurant_for_you.GremlinUtilities;
using System.Collections.Generic;

namespace restaurant_for_you.Services
{
    public class CityService : ICityService
    {

        readonly GraphTraversalSource _g;

        public CityService(GraphTraversalSource g) => _g = g;

        public Option<List<City>> GetAllCities()
            => from cities in _g.GetAllVerticesForLabel("city")
               select JsonConvert.DeserializeObject<List<City>>(JsonConvert.SerializeObject(cities));

        public Option<Vertex> GetVertexForACity(City city)
            => _g.GetVertex("city", "AreaCode", city.AreaCode);
    }
}
