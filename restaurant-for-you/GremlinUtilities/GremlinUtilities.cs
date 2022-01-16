using Gremlin.Net.Process.Traversal;
using Gremlin.Net.Structure;
using LaYumba.Functional;
using Newtonsoft.Json;
using System.Collections.Generic;
using static LaYumba.Functional.F;

namespace restaurant_for_you.GremlinUtilities
{
    public static class GremlinUtilities
    {
        public static Option<Vertex> GetVertex(this GraphTraversalSource g, string vertexLabel, 
            string attribute, object value)
            => g.V().Has(vertexLabel, attribute, value).Next();

        public static Option<Vertex> GetVertex(this GraphTraversalSource g, int id)
            => g.V(id).Next();

        public static Option<Edge> CreateEdge(this GraphTraversalSource g, string label, Vertex from, Vertex to)
            => g.AddE(label).From(from).To(to).Next();

        public static Option<IList<IDictionary<string, object>>> GetAllVerticesForLabel
            (this GraphTraversalSource g, string vertexLabel)
        {
            var result = g.V().HasLabel(vertexLabel)
                .ValueMap<string, object>().By(__.Unfold<object>()).ToList();
            return result.Count > 0 ? Some(result): None;
        }

        public static TT Convert<TT>(this object data) =>
            JsonConvert.DeserializeObject<TT>(JsonConvert.SerializeObject(data));
    }
}
