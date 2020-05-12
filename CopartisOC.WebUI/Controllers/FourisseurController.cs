using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopartisOC.Application.Fourisseur.Commands.CreateFourisseur;
using CopartisOC.Application.Fourisseur.Queries.GetFourisseurList;
using Microsoft.AspNetCore.Mvc;

namespace CopartisOC.WebUI.Controllers
{
    public class FourisseurController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<FourisseurListVm>> GetAll()
        {
            var vm = await Mediator.Send(new GetFourisseurListQuery());

            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create(CreateFourisseurCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}