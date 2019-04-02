using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScootersCountService.Core;

namespace ScootersCountService.Controllers
{
    [Route("/countService")]
    [ApiController]
    public class CountServiceController : ControllerBase
    {
        private ICountService _countService;
        public CountServiceController(ICountService countService)
        {
            this._countService = countService;
        }
        // POST /countService
        [HttpPost]
        public ActionResult<int> Post([FromBody] RequestBody body)
        {
            int[] scooters = body.Scooters;
            int c = body.C;
            int p = body.P;

            var result = _countService.CountMinFE(scooters, c, p);
            return result;
        }
    }

    public class RequestBody
    {
        public int[] Scooters { get; set; }
        public int C { get; set; }
        public int P { get; set; }
    }
}
