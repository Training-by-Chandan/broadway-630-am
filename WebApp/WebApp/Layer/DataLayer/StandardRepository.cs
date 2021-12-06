using System.Collections.Generic;
using System.Linq;
using WebApp.Models;

namespace WebApp.Layer.DataLayer
{
    public class StandardRepository : RepositoryBase, IStandardRepository
    {
        public IQueryable<Standards> GetStandards()
        {
            return db.Standards.AsQueryable();
        }
    }

    public interface IStandardRepository
    {
        IQueryable<Standards> GetStandards();
    }
}
