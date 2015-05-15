using BeerBI.Data;
using System.Linq;
using System.Web.Http;
using System.Web.OData;
using System.Web.OData.Routing;

namespace BeerBI.Controllers
{
    public class BeerController : ODataController
    {
        BeerBI.Data.Repository.BeerBIDataContext DB = new BeerBI.Data.Repository.BeerBIDataContext(DBSingleton.Instance.GetDBConnection());

        [EnableQuery]
        public IQueryable<BeerBI.Data.Repository.Beer> Get()
        {
            return DB.Beers.AsQueryable();

        }
        [EnableQuery]
        public SingleResult<BeerBI.Data.Repository.Beer> Get([FromODataUri] int key)
        {
            var result = DB.Beers.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }
    }
}
