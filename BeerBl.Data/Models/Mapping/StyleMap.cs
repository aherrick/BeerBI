using BeerBI.Data;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerBI.Data.Models.Mapping
{
    public class StyleMap : CsvClassMap<Style>
    {
        public StyleMap()
        {
            Map(m => m.Id).Name("id");
            Map(m => m.CategoryId).Name("cat_id");
            Map(m => m.Name).Name("style_name");
            Map(m => m.LastModified).Name("last_mod");
        }
    }
}
