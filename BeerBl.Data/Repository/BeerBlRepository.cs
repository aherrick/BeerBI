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
                       Website = sqlBrewery.Website,
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

        public IQueryable<Category> GetCategories()
        {
            return from sqlCategory in DB.Categories
                   select new Category
                   {
                       Id = sqlCategory.Id,
                       Name = sqlCategory.Name,
                       LastModified = sqlCategory.ModifiedOn.ToString()

                   };
        }

        public int SaveCategory(Category category)
        {
            var sqlCategory = DB.Categories.Where(x => x.Id == category.Id).SingleOrDefault();
            var isNew = false;

            if (sqlCategory == null)
            {
                isNew = true;
                sqlCategory = new BeerBI.Data.Repository.Category();
                sqlCategory.CreatedBy = category.LastModified;
                sqlCategory.CreatedOn = DateTime.UtcNow;
            }

            sqlCategory.Name = category.Name;

            sqlCategory.ModifiedBy = category.LastModified;
            sqlCategory.ModifiedOn = DateTime.UtcNow;

            if (isNew)
                DB.Categories.InsertOnSubmit(sqlCategory);

            DB.SubmitChanges();

            return sqlCategory.Id;
        }

        public void DeleteCategory(int id)
        {
            var dbCategory = DB.Categories.Where(x => x.Id == id).SingleOrDefault();

            if (dbCategory != null)
            {
                DB.Categories.DeleteOnSubmit(dbCategory);
                DB.SubmitChanges();
            }
        }

        #endregion

        #region Geocode

        public IQueryable<Geocode> GetGeocodes()
        {
            return from sqlGeocode in DB.Geocodes
                   select new Geocode
                   {
                       Id = sqlGeocode.Id,
                       BreweryId = sqlGeocode.BreweryId,
                       Latitude = sqlGeocode.Latitude,
                       Longitude = sqlGeocode.Longitude,
                       Accuracy = sqlGeocode.Accuracy
                   };
        }

        public int SaveGeocode(Geocode geocode)
        {
            var sqlGeocode = DB.Geocodes.Where(x => x.Id == geocode.Id).SingleOrDefault();
            var isNew = false;

            if (sqlGeocode == null)
            {
                isNew = true;
                sqlGeocode = new BeerBI.Data.Repository.Geocode();
                sqlGeocode.CreatedBy = "";
                sqlGeocode.CreatedOn = DateTime.UtcNow;
            }

            sqlGeocode.BreweryId = geocode.BreweryId;
            sqlGeocode.Latitude = geocode.Latitude;
            sqlGeocode.Longitude = geocode.Longitude;
            sqlGeocode.Accuracy = geocode.Accuracy;

            if (isNew)
                DB.Geocodes.InsertOnSubmit(sqlGeocode);

            DB.SubmitChanges();

            return sqlGeocode.Id;
        }

        public void DeleteGeocode(int id)
        {
            var dbGeocode = DB.Geocodes.Where(x => x.Id == id).SingleOrDefault();

            if (dbGeocode != null)
            {
                DB.Geocodes.DeleteOnSubmit(dbGeocode);
                DB.SubmitChanges();
            }
        }

        #endregion

        #region Style

        public IQueryable<Style> GetStyles()
        {
            return from sqlStyle in DB.Styles
                   select new Style
                   {
                       Id = sqlStyle.Id,
                       CategoryId = sqlStyle.CategoryId,
                       Name = sqlStyle.Name,
                       LastModified = sqlStyle.ModifiedBy
                   };
        }

        public int SaveStyle(Style style)
        {
            var sqlStyle = DB.Styles.Where(x => x.Id == style.Id).SingleOrDefault();
            var isNew = false;

            if (sqlStyle == null)
            {
                isNew = true;
                sqlStyle = new BeerBI.Data.Repository.Style();
                sqlStyle.CreatedBy = "";
                sqlStyle.CreatedOn = DateTime.UtcNow;
            }

            sqlStyle.CategoryId = style.CategoryId;
            sqlStyle.Name = style.Name;
            sqlStyle.ModifiedBy = style.LastModified;

            if (isNew)
                DB.Styles.InsertOnSubmit(sqlStyle);

            DB.SubmitChanges();

            return sqlStyle.Id;
        }

        public void DeleteStyle(int id)
        {
            var dbStyle = DB.Styles.Where(x => x.Id == id).SingleOrDefault();

            if (dbStyle != null)
            {
                DB.Styles.DeleteOnSubmit(dbStyle);
                DB.SubmitChanges();
            }
        }

        #endregion
    }
}
