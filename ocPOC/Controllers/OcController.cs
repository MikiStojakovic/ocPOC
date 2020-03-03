using Microsoft.AspNetCore.Mvc;
using ocPOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ocPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OcController : Controller
    {
        public OcController(IOdcRepository odcRepository)
        {
            OdcRepository = odcRepository;
        }

        public IOdcRepository OdcRepository { get; }

        [HttpGet]
        public IActionResult Get()
        {
            var result = OdcRepository.GetAllOc();

            var rr = result.ToList();
            rr.Add(new OuvertureCompte() { Id = 4, OcRef = "Ref4", PropertyOne = "prop4" });

            return Ok(rr);
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = OdcRepository.GetOc(id);

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post([FromBody]OuvertureCompte oc)
        {
            var result = OdcRepository.Add(oc);

            return Ok(result);
        }

        //[HttpGet]
        //public IEnumerable<OuvertureCompte> Get() 
        //{
        //    var result = OdcRepository.GetAllOc();

        //    var rr = result.ToList();
        //    rr.Add(new OuvertureCompte() { Id = 4, OcRef = "Ref4", PropertyOne = "prop4" });

        //    return rr;
        //}

        //[HttpGet]

        //public OuvertureCompte Get(int id)
        //{
        //    var result = OdcRepository.GetOc(id);

        //    return result;
        //}
    }
}
