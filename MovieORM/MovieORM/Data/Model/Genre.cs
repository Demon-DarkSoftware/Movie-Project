using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieORM.Data.Model
{
    public class Genre
    {
        public Genre(string name)
        {
         
            Name = name;
        }
        public Genre() { }
        public int ID { get; set; }
        public string Name { get; set; }
    }       
}
