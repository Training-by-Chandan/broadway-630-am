using WebApp.Models;

namespace WebApp.Layer.DataLayer
{
    public class RepositoryBase
    {
        protected ApplicationDbContext db = new ApplicationDbContext();
    }
}
