using Gremlin.Net.Process.Traversal;
using Gremlin.Net.Structure;
using LaYumba.Functional;
using resturant_for_you.Domain;
using System;

namespace resturant_for_you.GremlinUtilities
{
    public static class GremlinUtilities
    {

        //public static Func<GraphTraversalSource, Option<Vertex>> GetVertex(string vertexLabel, string attribute, object value)
        //    => (_g) => _g.V().Has(vertexLabel, attribute, value).Next();

        public static Func<GraphTraversalSource, Option<Vertex>> GetCityVertex(this City city)
            => (_g) => _g.V().Has("city", "AreaCode", city.AreaCode).Next();
    }
}
