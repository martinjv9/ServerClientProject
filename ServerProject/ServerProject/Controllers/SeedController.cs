using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StinkyModule;

namespace ServerProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedController(WorldCitiesSourceContext context) : ControllerBase
    {
        [HttpPost("Countries")]
        public async Task<ActionResult> ImportCountriesAsync()
        {

        }

        [HttpPost("Cities")]
        public async Task<ActionResult> ImportCitiesAsync()
        {

        }



    }
}
