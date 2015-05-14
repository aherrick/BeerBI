using BeerBI.Data;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerBI.Data.Models.Mapping
{
    public class BeerMap : CsvClassMap<Beer>
    {
        public BeerMap()
        {
            Map(m => m.Id).Name("id");
            Map(m => m.BreweryId).Name("brewery_id");
            Map(m => m.Name).Name("name");
            Map(m => m.CategoryId).Name("cat_id");
            Map(m => m.StyleId).Name("style_id");
            Map(m => m.ABV).Name("abv");
            Map(m => m.IBU).Name("ibu");
            Map(m => m.SRM).Name("srm");
            Map(m => m.UPC).Name("upc");
            Map(m => m.FilePath).Name("filepath");
            Map(m => m.Description).Name("descript");
            Map(m => m.AddUser).Name("add_user");
            Map(m => m.LastModified).Name("last_mod");
        }
    }
}
