using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerBI.Data
{
    public class BeerBIService
    {
        BeerBIRepository _repo = new BeerBIRepository();

        #region Beer

        public List<Beer> GetBeers()
        {
            return _repo.GetBeers().ToList();
        }

        public int SaveBeer(Beer beer)
        {
            return _repo.SaveBeer(beer);
        }

        public void DeleteBeer(int id)
        {
            _repo.DeleteBeer(id);
        }

        #endregion

        #region Brewery

        public List<Brewery> GetBreweries()
        {
            return _repo.GetBreweries().ToList();
        }

        public int SaveBrewery(Brewery brewery)
        {
            return _repo.SaveBrewery(brewery);
        }

        public void DeleteBrewery(int id)
        {
            _repo.DeleteBrewery(id);
        }

        #endregion

        #region Category



        #endregion

        #region Geocode



        #endregion

        #region Style



        #endregion
    }
}
