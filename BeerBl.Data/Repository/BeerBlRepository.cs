using BeerBl.Data.Repository;

namespace BeerBl.Data
{
    public class BeerBlRepository
    {
        #region DB

        BeerBlDataContext DB = new BeerBlDataContext(DBSingleton.Instance.GetDBConnection());

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
