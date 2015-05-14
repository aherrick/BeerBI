using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerBI.Data
{
    public class Beer
    {
        public int Id { get; set; }
        public int BreweryId { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int StyleId { get; set; }
        public decimal? ABV { get; set; }
        public decimal? IBU { get; set; }
        public decimal? SRM { get; set; }
        public decimal? UPC { get; set; }
        public string FilePath { get; set; }
        public string Description { get; set; }
        public string AddUser { get; set; }
        public string LastModified { get; set; }
    }
}