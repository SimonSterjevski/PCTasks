using CompanyApp.Logic;
using CompanyApp.Logic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {
        private ISuplyImplementation _suplyImplementation;
        public DeliveryController(ISuplyImplementation suplyImplementation)
        {
            _suplyImplementation = suplyImplementation;
        }

        //[HttpGet]
        //public ActionResult<string> Get()
        //{
        //    return "Simon";
        //}

        [HttpPost]
        public IActionResult PostSuply([FromBody] Demand demand)
        {
            try
            {
                _suplyImplementation.CreateAndAddSuply(demand);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
        }
    }
}
