using BeerBI.Data;
using BeerBI.Data.Repository;
using System;
using System.Linq;

namespace BeerBI.Data
{
    public class BeerBIRepository
    {
        #region DB

        BeerBIDataContext DB = new BeerBIDataContext(DBSingleton.Instance.GetDBConnection());

        #endregion

        #region Beer

        public IQueryable<Beer> GetBeers()
        {
            return from sqlBeer in DB.Beers
                   select new Beer
                   {
                       Id = sqlBeer.Id,
                       BreweryId = sqlBeer.BreweryId,
                       Name = sqlBeer.Name,
                       CategoryId = sqlBeer.CategoryId,
                       StyleId = sqlBeer.StyleId,
                       ABV = sqlBeer.Abv,
                       IBU = sqlBeer.Ibu,
                       SRM = sqlBeer.Srm,
                       UPC = sqlBeer.Upc,
                       FilePath = sqlBeer.Filepath,
                       Description = sqlBeer.Description,
                       AddUser = sqlBeer.CreatedBy,
                       LastModified = sqlBeer.ModifiedOn.ToString()
                       
                   };
        }

        public int SaveBeer(Beer beer)
        {
            var sqlBeer = DB.Beers.Where(x => x.Id == beer.Id).SingleOrDefault();
            var isNew = false;

            if (sqlBeer == null)
            {
                isNew = true;
                sqlBeer = new BeerBI.Data.Repository.Beer();
                sqlBeer.CreatedBy = beer.AddUser;
                sqlBeer.CreatedOn = DateTime.UtcNow;
            }

            sqlBeer.BreweryId = beer.BreweryId;
            sqlBeer.Name = beer.Name;
            sqlBeer.CategoryId = beer.CategoryId;
            sqlBeer.StyleId = beer.StyleId;
            sqlBeer.Abv = beer.ABV;
            sqlBeer.Ibu = beer.IBU;
            sqlBeer.Srm = beer.SRM;
            sqlBeer.Upc = beer.UPC;
            sqlBeer.Filepath = beer.FilePath;
            sqlBeer.Description = beer.Description;

            sqlBeer.ModifiedBy = beer.AddUser;
            sqlBeer.ModifiedOn = DateTime.UtcNow;

            if (isNew)
                DB.Beers.InsertOnSubmit(sqlBeer);

            DB.SubmitChanges();

            return sqlBeer.Id;
        }

        public void DeleteBeer(int id)
        {
            var dbBeer = DB.Beers.Where(x => x.Id == id).SingleOrDefault();

            if (dbBeer != null)
            {
                DB.Beers.DeleteOnSubmit(dbBeer);
                DB.SubmitChanges();
            }
        }

        #endregion

        #region Brewery


        public IQueryable<Brewery> GetBreweries()
        {
            return from sqlBrewery in DB.Breweries
                   select new Brewery
                   {
                       Id = sqlBrewery.Id,
                       OpenBeerDBId = sqlBrewery.OpenBeerDBId,
                       Name = sqlBrewery.Name,
                       Address1 = sqlBrewery.Address1,
                       Address2 = sqlBrewery.Address2,
                       City = sqlBrewery.City,
                       State = sqlBrewery.State,
                       Code = sqlBrewery.ZipCode,
                       Country = sqlBrewery.Country,
                       Phone = sqlBrewery.Phone,
                       Website = new Uri(sqlBrewery.Website),
                       FilePath = sqlBrewery.FilePath,
                       Description = sqlBrewery.Description,
                       AddUser = sqlBrewery.CreatedBy,
                       LastModified = sqlBrewery.ModifiedOn.ToString()

                   };
        }

        public int SaveBrewery(Brewery brewery)
        {
            var sqlBrewery = DB.Breweries.Where(x => x.OpenBeerDBId == brewery.OpenBeerDBId).SingleOrDefault();
            var isNew = false;

            if (sqlBrewery == null)
            {
                isNew = true;
                sqlBrewery = new BeerBI.Data.Repository.Brewery();
                sqlBrewery.CreatedBy = brewery.AddUser;
                sqlBrewery.CreatedOn = DateTime.UtcNow;
            }

            sqlBrewery.OpenBeerDBId = brewery.OpenBeerDBId;
            sqlBrewery.Name = brewery.Name;
            sqlBrewery.Address1 = brewery.Address1;
            sqlBrewery.Address2 = brewery.Address2;
            sqlBrewery.City = brewery.City;
            sqlBrewery.State = brewery.State;
            sqlBrewery.ZipCode = brewery.Code;
            sqlBrewery.Country = brewery.Country;
            sqlBrewery.Phone = brewery.Phone;
            sqlBrewery.Website = brewery.Website == null ? "" : brewery.Website.ToString();
            sqlBrewery.FilePath = brewery.FilePath;
            sqlBrewery.Description = brewery.Description;

            sqlBrewery.ModifiedBy = brewery.AddUser;
            sqlBrewery.ModifiedOn = DateTime.UtcNow;

            if (isNew)
                DB.Breweries.InsertOnSubmit(sqlBrewery);

            DB.SubmitChanges();

            return sqlBrewery.Id;
        }

        public void DeleteBrewery(int id)
        {
            var dbBrewery = DB.Breweries.Where(x => x.Id == id).SingleOrDefault();

            if (dbBrewery != null)
            {
                DB.Breweries.DeleteOnSubmit(dbBrewery);
                DB.SubmitChanges();
            }
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
