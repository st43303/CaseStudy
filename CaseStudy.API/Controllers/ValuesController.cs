using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudy.API.Controllers
{
    /// <summary>
    /// Můj první controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// Moje první metoda
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> GetStrings()
        {
            return new string[]
            {
                "Hello world",
                "Hello Galaxy",
                "Hello Universe"
            };
        }

        /// <summary>
        /// Moje druhá metoda
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public string GetStringById(int id)
        {
            return "Hello";
        }
        
    }
}
