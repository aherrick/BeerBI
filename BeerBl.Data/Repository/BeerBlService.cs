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

        public List<Category> GetCategories()
        {
            return _repo.GetCategories().ToList();
        }

        public int SaveCategory(Category category)
        {
            return _repo.SaveCategory(category);
        }

        public void DeleteCategory(int id)
        {
            _repo.DeleteCategory(id);
        }

        #endregion

        #region Geocode

        public List<Geocode> GetGeocodes()
        {
            return _repo.GetGeocodes().ToList();
        }

        public int SaveGeocode(Geocode geocode)
        {
            return _repo.SaveGeocode(geocode);
        }

        public void DeleteGeocode(int id)
        {
            _repo.DeleteGeocode(id);
        }

        #endregion

        #region Style

        public List<Style> GetStyles()
        {
            return _repo.GetStyles().ToList();
        }

        public int SaveStyle(Style style)
        {
            return _repo.SaveStyle(style);
        }

        public void DeleteStyle(int id)
        {
            _repo.DeleteStyle(id);
        }

        #endregion
    }
}
