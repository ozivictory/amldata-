using amldata.Data;
using amldata.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace amldata.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly DestinationDbContext _destDb;
        private readonly CarpEnvDbContext _carpDb;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db, DestinationDbContext destDb, CarpEnvDbContext carpDb)
        {
            _logger = logger;
            _db = db;
            _destDb = destDb;
            _carpDb = carpDb;
        }

        // reference https://www.c-sharpcorner.com/article/working-with-json-string-in-C-Sharp/
        public IActionResult Index()
        {
            // load source data
            IEnumerable<AirbyteData> allSourceData =  _db._airbyte_raw_ctr11.ToList();

            // parse json string
            foreach(var data in allSourceData)
            {
                var ctrRecord = JsonConvert.DeserializeObject<ctrdesc>(data._airbyte_data);

                _destDb.CTR.Add(ctrRecord);

            }
            // move source to destination
            _destDb.SaveChanges();


            // move destination to carp env
            IEnumerable<ctrdesc> destDbData = _destDb.CTR.ToList();

            foreach(var data in destDbData)
            {
                _carpDb.CTR.Add(data);
            }
            _carpDb.SaveChanges();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}