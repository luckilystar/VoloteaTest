using VoloteaTest.Core.Models.People;
using VoloteaTest.EF;

namespace VoloteaTest.Repository.People
{
    public class PeopleRepository:GenericRepository<Person>,IPeopleRepository
    {
        public PeopleRepository():base()
        {
            
        }
        public PeopleRepository(PeopleDbContext context)
          : base(context)
        {

        }
    }
}
