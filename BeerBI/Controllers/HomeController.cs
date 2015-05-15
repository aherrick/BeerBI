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

        #region JSON

        [HttpGet]
        public JsonResult JSONGetBeers()
        {
            var beers = _service.GetBeers().Take(25).ToList();

            return Json(beers, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult JSONGetBreweries()
        {
            var breweries = _service.GetBreweries().Take(25).ToList();

            return Json(breweries, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult JSONGetGeocodes()
        {
            var breweries = _service.GetGeocodes().Take(25).ToList();

            return Json(breweries, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult JSONGetStyles()
        {
            var breweries = _service.GetStyles();

            return Json(breweries, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult JSONGetCategories()
        {
            var breweries = _service.GetCategories();

            return Json(breweries, JsonRequestBehavior.AllowGet);
        }
        #endregion

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
                    else if (dataType == "Geocodes")
                    {
                        var geocodes = BeerBICSVHelper.GetData<Geocode, GeocodeMap>(httpPostedFile);

                        foreach (var geocode in geocodes)
                        {
                            _service.SaveGeocode((Geocode)geocode);
                        }
                        // save all beers
                    }
                    else if (dataType == "Styles")
                    {
                        var styles = BeerBICSVHelper.GetData<Style, StyleMap>(httpPostedFile);

                        foreach (var style in styles)
                        {
                            _service.SaveStyle((Style)style);
                        }
                        // save all beers
                    }
                    else if (dataType == "Categories")
                    {
                        var categories = BeerBICSVHelper.GetData<Category, CategoryMap>(httpPostedFile);

                        foreach (var category in categories)
                        {
                            _service.SaveCategory((Category)category);
                        }
                        // save all beers
                    }
                }
            }
        }
    }
}