using Gremlin.Net.Driver;
using Gremlin.Net.Driver.Remote;
using Gremlin.Net.Process.Traversal;
using System;

namespace resturant_for_you.Bootstrapping
{
    public class GraphDbService
    {
        public static GremlinClient GetGremlinClient()
        {
            var gremlinServer = new GremlinServer(
               hostname: "localhost",
               port: 8182,
               enableSsl: false,
               username: null,
               password: null
           );

            var connectionPoolSettings = new ConnectionPoolSettings
            {
                MaxInProcessPerConnection = 32,
                PoolSize = 4,
                ReconnectionAttempts = 4,
                ReconnectionBaseDelay = TimeSpan.FromSeconds(1)
            };

            return new GremlinClient(
                gremlinServer: gremlinServer,
                connectionPoolSettings: connectionPoolSettings
            );
        }

        public static GraphTraversalSource GenerateGraphTraversalSource(GremlinClient gremlinClient)
        {
            var driverRemoteConnection = new DriverRemoteConnection(gremlinClient, "g");
            return AnonymousTraversalSource.Traversal().WithRemote(driverRemoteConnection);
        }

    }
}
