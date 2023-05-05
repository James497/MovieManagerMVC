using MovieManagerMVC.Data.Base;
using MovieManagerMVC.Models;

namespace MovieManagerMVC.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {

        public ActorsService(AppDbContext context):base(context)
        {
        }
    }
}
