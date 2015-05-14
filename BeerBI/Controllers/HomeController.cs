using BeerBI.Data;
using BeerBI.Data.Models.Mapping;
using BeerBI.Helpers;
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
        BeerBIService _service = new BeerBIService();

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
                   
                        var beers = BeerBICSVHelper.GetData<Beer, BeerMap>(httpPostedFile);

                        foreach(var beer in beers)
                        {
                            _service.SaveBeer((Beer) beer);
                        }
                        // save all beers
                    }else if (dataType == "Breweries")
                    {


                        var breweries = BeerBICSVHelper.GetData<Brewery, BreweryMap>(httpPostedFile);

                        foreach (var brewery in breweries)
                        {
                            _service.SaveBrewery((Brewery) brewery);
                        }
                        // save all beers
                    }
                }
            }
        }
    }
}