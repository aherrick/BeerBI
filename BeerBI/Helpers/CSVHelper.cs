using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace BeerBI.Helpers
{
    public static class BeerBICSVHelper
    {

        public static Array GetData<T>(HttpPostedFileBase file)
        {

            try
            {
                using (var reader = new StreamReader(file.InputStream))
                using (var csvReader = new CsvReader(reader))
                {
                    csvReader.Read();
                    return csvReader.GetRecords<T>().ToArray();
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}