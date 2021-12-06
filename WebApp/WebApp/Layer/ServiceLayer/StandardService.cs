using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApp.Layer.DataLayer;

namespace WebApp.Layer.ServiceLayer
{
    public class StandardService : IStandardService
    {
        private IStandardRepository standardRepository = new StandardRepository();

        public IEnumerable<SelectListItem> GetStandardsList()
        {
            return standardRepository.GetStandards().Select(p => new SelectListItem
            {
                Text = p.Name,
                Value = p.Id.ToString()
            }).AsEnumerable();
        }
    }

    public interface IStandardService
    {
        IEnumerable<SelectListItem> GetStandardsList();
    }
}
