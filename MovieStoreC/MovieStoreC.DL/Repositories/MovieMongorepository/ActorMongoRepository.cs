using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MovieStoreC.Models.configuration;
using MovieStoreC.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreC.DL.Repositories.MovieMongorepository
{
    internal class ActorMongoRepository
    {
        private readonly IMongoCollection<Actor> _movieCollection;
        private readonly ILogger<ActorMongoRepository> _logger;
        public ActorMongoRepository(IOptionsMonitor<MongoDbConfiguration> mongoConfig, ILogger<ActorMongoRepository> logger)
        {
            _logger = logger;
            var client = new MongoClient(mongoConfig.CurrentValue.ConnectionString);
            var database = client.GetDatabase(mongoConfig.CurrentValue.ConnectionString);
            _movieCollection = database.GetCollection<Actor>(nameof(Actor));
        }
        public List<Actor> GetAll()
        {
            return _movieCollection.Find(m => true).ToList();
        }
        public Actor? Get(int id)
        {
            throw new NotImplementedException();
        }

        public Actor? GetById(int id)
        {
            throw new NotImplementedException();
        }

    }
}
