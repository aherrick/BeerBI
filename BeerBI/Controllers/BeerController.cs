using System.Linq;
using System.Web.Http;
using System.Web.OData;
using System.Web.OData.Routing;

namespace BeerBI.Controllers
{
    public class BeerController : ODataController
    {
        BeerBI.Data.Repository.BeerBIDataContext db = new BeerBI.Data.Repository.BeerBIDataContext();

        

        [EnableQuery]
        public IQueryable<BeerBI.Data.Repository.Beer> Get()
        {
            return db.Beers.AsQueryable();

        }
        [EnableQuery]
        public SingleResult<BeerBI.Data.Repository.Beer> Get([FromODataUri] int key)
        {
            IQueryable<BeerBI.Data.Repository.Beer> result = db.Beers.Where(p => p.Id == key).AsQueryable();
            return SingleResult.Create(result);
        }
    }
}
