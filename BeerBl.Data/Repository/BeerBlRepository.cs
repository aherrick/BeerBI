using BeerBI.Data.Repository;

namespace BeerBI.Data
{
    public class BeerBIRepository
    {
        #region DB

        BeerBIDataContext DB = new BeerBIDataContext(DBSingleton.Instance.GetDBConnection());

        #endregion

        #region Beer


        #endregion

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
