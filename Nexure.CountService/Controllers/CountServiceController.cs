using System;
using Microsoft.AspNetCore.Mvc;
using Nexure.CountService.Validators;
using NexureCountService.Core;

namespace NexureCountService.Controllers
{
    [Route("/countService")]
    [ApiController]
    public class CountServiceController : ControllerBase
    {
        private ICountService _countService;
        private IParamsValidator _paramvValidator;

        public CountServiceController(ICountService countService, IParamsValidator paramvValidator)
        {
            this._countService = countService;
            this._paramvValidator = paramvValidator;
        }

        // POST /countService
        [HttpPost]
        public ActionResult<int> Post([FromBody] RequestBody body)
        {
            int[] scooters = body.Scooters;
            int c = body.C;
            int p = body.P;

            try
            {
                _paramvValidator.Validate(scooters, c, p);
            }
            catch (Exception e)
            {
                Response.StatusCode = 400; // Bad Request
                return Content(e.Message);
            }

            return _countService.CountMinFE(scooters, c, p);
        }

        [HttpGet]
        public ActionResult Get()
        {
            return new BadRequestResult();
        }
    }

    public class RequestBody
    {
        public int[] Scooters { get; set; }
        public int C { get; set; }
        public int P { get; set; }
    }
}
