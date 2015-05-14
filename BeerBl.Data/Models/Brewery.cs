using System;

namespace BeerBI.Data
{
    public class Brewery
    {
        public int Id { get; set; }
        public int OpenBeerDBId { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Code { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public Uri Website { get; set; }
        public string FilePath { get; set; }
        public string Description { get; set; }
        public string AddUser { get; set; }
        public string LastModified { get; set; }
    }
}
