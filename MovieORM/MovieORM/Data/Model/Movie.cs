using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieORM.Data.Model
{
    public class Movie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<People> Actors { get; set; }
        public List<People> Producers { get; set; }
        public int YearOfCreation { get; set; }
        public int Duration { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Award> Awards { get; set; }

        public Movie() { }
        public Movie(string name, List<People> actors, List<People> producers, 
            int yOfCreation, int duration, List<Genre> genres, List<Award> awards) {
            Name = name;
            Actors = actors;
            Producers = producers;
            YearOfCreation = yOfCreation;
            Duration = duration;
            Genres = genres;
            Awards = awards;
        }
    }
}
