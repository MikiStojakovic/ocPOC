using CopartisOC.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopartisOC.Application.OuvertureCompte.Commands.CreateOuvertureCompte
{
    public class CreateOuvertureCompteCommand : IRequest<Guid>
    {
        public Guid OuvertureCompteId { get; set; }
        public string OcRef { get; set; }
        public string DocPath { get; set; }
        public ModeSoumission ModeSoumission { get; set; }
        public Guid ConseillerId { get; set; }       
    }
}
