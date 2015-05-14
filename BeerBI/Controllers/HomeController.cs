using BeerBI.Helpers;
using BeerBI.Models;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeerBI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void UploadBeers()
        {
            if (HttpContext.Request.Files.AllKeys.Any())
            {
                var httpPostedFile = HttpContext.Request.Files["UploadedBeers"];
                if (httpPostedFile != null)
                {
                    var dataType = HttpContext.Request.Form["DataType"].ToString();

                    if(dataType == "Beers")
                    {
                        var beers = BeerBICSVHelper.GetData<Beer>(httpPostedFile);

                        // save all beers
                    }
                }
            }
        }
    }
}