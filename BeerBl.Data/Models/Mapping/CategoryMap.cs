using BeerBI.Data;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerBI.Data.Models.Mapping
{
    public class CategoryMap : CsvClassMap<Category>
    {
        public CategoryMap()
        {
            Map(m => m.Id).Name("id");
            Map(m => m.Name).Name("cat_name");
            Map(m => m.LastModified).Name("last_mod");
        }
    }
}
