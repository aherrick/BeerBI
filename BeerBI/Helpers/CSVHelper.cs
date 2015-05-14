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

        public static Array GetData<T, TMap>(HttpPostedFileBase file)
            where TMap : CsvHelper.Configuration.CsvClassMap
        {
            try
            {
                using (var reader = new StreamReader(file.InputStream))
                using (var csvReader = new CsvReader(reader))
                {
                    csvReader.Configuration.RegisterClassMap<TMap>();
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