using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieORM.Data.Model
{
    public class People
    {
        public People(string firstName, string lastName, List<Award> awards, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Awards = awards;
            BirthDate = birthDate;
        }
        public People() { }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Award> Awards { get; set; }
        public DateTime BirthDate { get; set; }


    }
}
