using Gremlin.Net.Process.Traversal;
using Gremlin.Net.Structure;
using LaYumba.Functional;
using System;
using System.Collections.Generic;
using static LaYumba.Functional.F;

namespace resturant_for_you.GremlinUtilities
{
    public static class GremlinUtilities
    {

        public static Option<Vertex> GetVertex(this GraphTraversalSource _g, string vertexLabel, string attribute, object value)
            => _g.V().Has(vertexLabel, attribute, value).Next();

        public static Option<Edge> CreateEdge(this GraphTraversalSource _g, string label, Vertex from, Vertex to)
            => _g.AddE(label).From(from).To(to).Next();

        public static Option<IList<IDictionary<string, object>>> GetAllVerticesForLabel(this GraphTraversalSource _g, string vertexLabel)
        {
            var result = _g.V().HasLabel("city").ValueMap<string, object>().By(__.Unfold<object>()).ToList();
            return result.Count > 0 ? Some(result): None;
        }
    }
}
