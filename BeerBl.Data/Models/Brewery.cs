using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerBI.Data
{
    public class Brewery
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string code { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public Uri website { get; set; }
        public string filepath { get; set; }
        public string descript { get; set; }
        public string add_user { get; set; }
        public string last_mod { get; set; }
    }
}
