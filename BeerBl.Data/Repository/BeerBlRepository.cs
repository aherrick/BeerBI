using BeerBI.Data;
using BeerBI.Data.Repository;
using System.Linq;

namespace BeerBI.Data
{
    public class BeerBIRepository
    {
        #region DB

        BeerBIDataContext DB = new BeerBIDataContext(DBSingleton.Instance.GetDBConnection());

        #endregion
        /*
        #region Beer

        public IQueryable<BeerBI.Data.Beer> GetBeers()
        {
            return from sqlBeer in DB.Beers
                   select new BeerBI.Data.Beer
                   {
                       id = sqlBeer.Id,
                       brewery_id = sqlBeer.BreweryId,
                       name = sqlBeer.Name,
                       cat_id = sqlBeer.CategoryId,
                       style_id = sqlBeer.StyleId,
                       abv = sqlBeer.Abv,
                       ibu = sqlBeer.Ibu,
                       srm = sqlBeer.Srm,
                       upc = sqlBeer.Upc,
                       filepath = sqlBeer.Filepath,
                       descript = sqlBeer.Description,
                       add_user = sqlBeer.CreatedBy,
                       last_mod = sqlBeer.ModifiedOn.ToString()
                       
                   };
        }

        public int SaveInvoice(Invoice invoice)
        {
            var sqlInvoice = DB.Invoices.Where(x => x.Id == invoice.Id).SingleOrDefault();
            var isNew = false;

            if (sqlInvoice == null)
            {
                isNew = true;
                sqlInvoice = new Sql.Invoice();
                sqlInvoice.CreatedBy = invoice.CreatedBy;
                sqlInvoice.CreatedOn = DateTime.UtcNow;
            }

            sqlInvoice.AccountId = invoice.AccountId;
            sqlInvoice.Amount = invoice.Amount;
            sqlInvoice.Date = invoice.Date;
            sqlInvoice.Note = invoice.Note;
            sqlInvoice.ModifiedBy = invoice.ModifiedBy;
            sqlInvoice.ModifiedOn = DateTime.UtcNow;

            if (isNew)
                DB.Invoices.InsertOnSubmit(sqlInvoice);

            DB.SubmitChanges();

            return sqlInvoice.Id;
        }

        public void DeleteInvoice(int id)
        {
            var dbInvoice = DB.Invoices.Where(x => x.Id == id).SingleOrDefault();

            if (dbInvoice != null)
            {
                DB.Invoices.DeleteOnSubmit(dbInvoice);
                DB.SubmitChanges();
            }
        }

        #endregion
    * 
    * */

        #region Brewery



        #endregion

        #region Category



        #endregion

        #region Geocode



        #endregion

        #region Style



        #endregion
    }
}
