using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpleDataGenerator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimpleDataController : ControllerBase
    {
        [HttpGet("[action]")]
        public IEnumerable<int> GetRandomStrings(int records)
        {

            return null;

        }
    }
}