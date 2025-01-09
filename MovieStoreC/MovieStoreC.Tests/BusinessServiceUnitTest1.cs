using Moq;
using MovieStoreC.DL.Interfaces;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.Tests
{
    public class BusinessServiceUnitTest1
    {
        private readonly Mock<IMovieRepository> _movieRepositoryMock;
        private readonly Mock<IActorRepository> _actorRepositoryMock;
        private List<Actor> _actors = new List<Actor>()
        {

        new Actor()
        {
            Id = "e9332f79 - 308f - 4e1e - a928 - 01fdbdd8b936",
            Name = "Actor1"
        },
        new Actor()
        {
            Id = "8e180cc7 - 82c8 - 48d5 - 8113 - 7140c7fed23a",
            Name = "Actor2"
        },
        new Actor()
        {
            Id = "bf7b2c19 - ef86 - 4d7f - ba92 - 4a57e485be8d",
            Name = "Actor3"
        }

    };
        public BusinessServiceUnitTest1()
        {
            _movieRepositoryMock = new Mock<IMovieRepository>();
            _actorRepositoryMock = new Mock<IActorRepository>();
        }
        [Fact]
        public void GetAllMovies_Ok()
        {

        }
    }
}