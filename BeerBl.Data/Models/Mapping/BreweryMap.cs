using BeerBI.Data;
using CsvHelper.Configuration;

namespace BeerBI.Data.Models.Mapping
{
    public class BreweryMap : CsvClassMap<Brewery>
    {
        public BreweryMap()
        {
            Map(m => m.OpenBeerDBId).Name("id");
            Map(m => m.Name).Name("name");
            Map(m => m.Address1).Name("address1");
            Map(m => m.Address2).Name("address2");
            Map(m => m.City).Name("city");
            Map(m => m.State).Name("state");
            Map(m => m.Code).Name("code");
            Map(m => m.Country).Name("country");
            Map(m => m.Phone).Name("phone");
            Map(m => m.Website).Name("website");
            Map(m => m.FilePath).Name("filepath");
            Map(m => m.Description).Name("descript");
            Map(m => m.AddUser).Name("add_user");
            Map(m => m.LastModified).Name("last_mod");
        }
    }
}
