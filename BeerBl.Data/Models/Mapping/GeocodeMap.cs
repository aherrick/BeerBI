using BeerBI.Data;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerBI.Data.Models.Mapping
{
    public class GeocodeMap : CsvClassMap<Geocode>
    {
        public GeocodeMap()
        {
            Map(m => m.Id).Name("id");
            Map(m => m.BreweryId).Name("brewery_id");
            Map(m => m.Latitude).Name("latitude");
            Map(m => m.Longitude).Name("longitude");
            Map(m => m.Accuracy).Name("accuracy");
        }
    }
}
