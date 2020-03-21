using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieORM.Data.Model
{
    public class Award
    {
        public Award(string name)
        {
            Name = name;
        }
        public Award() { }
        public int ID { get; set; }
        public string Name { get; set; }


    }
}
