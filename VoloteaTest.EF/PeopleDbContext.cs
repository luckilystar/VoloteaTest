using System.Data.Entity;
using VoloteaTest.Core.Models.People;

namespace VoloteaTest.EF
{
    public class PeopleDbContext:DbContext
    {
        public PeopleDbContext()
        {

        }
        public IDbSet<Person> People { get; set; }
    }
}
