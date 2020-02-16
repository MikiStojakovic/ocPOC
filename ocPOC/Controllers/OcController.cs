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
        public IEnumerable<OuvertureCompte> GetAll() 
        {
            var result = OdcRepository.GetAllOc();

            var rr = result.ToList();
            rr.Add(new OuvertureCompte() { Id = 1, OcRef = "Ref1", PropertyOne = "prop1" });

            return rr;
        }
    }
}
