namespace BeerBI.Data
{
    public sealed class DBSingleton
    {
        private static readonly DBSingleton instance = new DBSingleton();
        private readonly string con = System.Configuration.ConfigurationManager.ConnectionStrings["BeerConnectionString"].ConnectionString;

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static DBSingleton()
        {
        }

        private DBSingleton()
        {
        }

        public static DBSingleton Instance
        {
            get
            {
                return instance;
            }
        }

        public string GetDBConnection()
        {
            return con;
        }
    }
}
