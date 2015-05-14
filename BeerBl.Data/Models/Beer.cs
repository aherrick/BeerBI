using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerBI.Data
{
    public class Beer
    {
        public int id { get; set; }
        public int brewery_id { get; set; }
        public string name { get; set; }
        public int cat_id { get; set; }
        public int style_id { get; set; }
        public decimal abv { get; set; }
        public decimal ibu { get; set; }
        public decimal srm { get; set; }
        public decimal upc { get; set; }
        public string filepath { get; set; }
        public string descript { get; set; }
        public string add_user { get; set; }
        public string last_mod { get; set; }
    }
}