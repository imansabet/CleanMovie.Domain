using CleanMovie.Application;
using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
       
        private readonly MovieDbContext _db;

        public MovieRepository(MovieDbContext db)
        {
            _db = db;
        }
        public Movie CreateMovie(Movie movie)
        {
            _db.Movies.Add(movie);
            _db.SaveChanges();
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            return _db.Movies.ToList( );
        }
    }
}
