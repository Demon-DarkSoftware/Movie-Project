using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieORM.Data;
using MovieORM.Data.Model;

namespace MovieORM.Business
{
    public class MovieBusiness
    {
        private MovieContext context;
        public List<Movie> GetAllMovies() {
            using (context = new MovieContext()) {
                return context.Movies.ToList();
            }
        }

        public List<People> GetAllPeople()
        {
            using (context = new MovieContext())
            {
                return context.Peoples.ToList();
            }
        }
        public List<Genre> GetAllGenres()
        {
            using (context = new MovieContext())
            {
                return context.Genres.ToList();
            }
        }
        public List<Award> GetAllAwards()
        {
            using (context = new MovieContext())
            {
                return context.Awards.ToList();
            }
        }
        #region Data Get
        public Movie GetMovie(int id) {
            Movie movieFound;
            using (context = new MovieContext()) {
                var movieRequested = (from p in context.Movies where p.ID == id select p).ToList()[0];
                movieFound = movieRequested;
            }
            return movieFound; 
        }
        public People GetPeople(int id)
        {
            People movieFound;
            using (context = new MovieContext())
            {
                var movieRequested = (from p in context.Peoples where p.ID == id select p).ToList()[0];
                movieFound = movieRequested;
            }
            return movieFound;
        }

        public Genre GetGenre(int id)
        {
            Genre movieFound;
            using (context = new MovieContext())
            {
                var movieRequested = (from p in context.Genres where p.ID == id select p).ToList()[0];
                movieFound = movieRequested;
            }
            return movieFound;
        }
        public Award GetAward(int id)
        {
            Award movieFound;
            using (context = new MovieContext())
            {
                var movieRequested = (from p in context.Awards where p.ID == id select p).ToList()[0];
                movieFound = movieRequested;
            }
            return movieFound;
        }
        #endregion
        #region Data Adding
        public void AddMovie(Movie movieToBeAdded) {
            using (context = new MovieContext()) {
                context.Movies.Add(movieToBeAdded);
                context.SaveChanges();
            }
        }
        public void AddPeople(People movieToBeAdded)
        {
            using (context = new MovieContext())
            {
                context.Peoples.Add(movieToBeAdded);
                context.SaveChanges();
            }
        }
        public void AddGenre(Genre movieToBeAdded)
        {
            using (context = new MovieContext())
            {
                context.Genres.Add(movieToBeAdded);
                context.SaveChanges();
            }
        }
        public void AddAward(Award movieToBeAdded)
        {
            using (context = new MovieContext())
            {
                context.Awards.Add(movieToBeAdded);
                context.SaveChanges();
            }
        }
        #endregion
        #region Data Deleting
        public void RemoveMovie(int id) {
            using (context = new MovieContext()) {
                Movie temp = GetMovie(id);
                if (temp != null) {
                    context.Movies.Remove(temp);
                    context.SaveChanges();
                }
            }
        }
        public void RemovePeople(int id)
        {
            using (context = new MovieContext())
            {
                People temp = GetPeople(id);
                if (temp != null)
                {
                    context.Peoples.Remove(temp);
                    context.SaveChanges();
                }
            }
        }
        public void RemoveAward(int id)
        {
            using (context = new MovieContext())
            {
                Award temp = GetAward(id);
                if (temp != null)
                {
                    context.Awards.Remove(temp);
                    context.SaveChanges();
                }
            }
        }
        public void RemoveGenre(int id)
        {
            using (context = new MovieContext())
            {
                Genre temp = GetGenre(id);
                if (temp != null)
                {
                    context.Genres.Remove(temp);
                    context.SaveChanges();
                }
            }
        }
        #endregion
        #region Data Update
        public void MovieUpdate(Movie movieRequested) {
            using (context = new MovieContext()) {
                var refereced = GetMovie(movieRequested.ID);
                if (refereced != null) {
                    context.Entry(refereced).CurrentValues.SetValues(movieRequested);
                    context.SaveChanges();
                }
            }
        }
        public void PeopleUpdate(People movieRequested)
        {
            using (context = new MovieContext())
            {
                var refereced = GetPeople(movieRequested.ID);
                if (refereced != null)
                {
                    context.Entry(refereced).CurrentValues.SetValues(movieRequested);
                    context.SaveChanges();
                }
            }
        }
        public void GenreUpdate(Genre movieRequested)
        {
            using (context = new MovieContext())
            {
                var refereced = GetGenre(movieRequested.ID);
                if (refereced != null)
                {
                    context.Entry(refereced).CurrentValues.SetValues(movieRequested);
                    context.SaveChanges();
                }
            }
        }
        public void AwardUpdate(Award movieRequested)
        {
            using (context = new MovieContext())
            {
                var refereced = GetAward(movieRequested.ID);
                if (refereced != null)
                {
                    context.Entry(refereced).CurrentValues.SetValues(movieRequested);
                    context.SaveChanges();
                }
            }
        }
        #endregion
    }
}
