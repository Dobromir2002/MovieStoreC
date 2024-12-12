using DnsClient.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MovieStoreC.DL.Interfaces;
using MovieStoreC.Models.configuration;
using MovieStoreC.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreC.DL.Repositories.MovieMongorepository
{
    internal class MovieMongoRepository :IMovieRepository
    {
        private readonly IMongoCollection<Movie> _movieCollection;
        private readonly ILogger<MovieMongoRepository> _logger;
        public MovieMongoRepository(IOptionsMonitor<MongoDbConfiguration>mongoConfig,ILogger<MovieMongoRepository> logger)
        {
            _logger = logger;
            var client = new MongoClient(mongoConfig.CurrentValue.ConnectionString);
            var database=client.GetDatabase(mongoConfig.CurrentValue.ConnectionString); 
            _movieCollection=database.GetCollection<Movie>(nameof(Movie));
        }
        public List<Movie> GetAll()
        {
            return _movieCollection.Find(m => true).ToList();
        }
        public Movie? Get(int id)
        {
            throw new NotImplementedException();
        }

        public Movie? GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
