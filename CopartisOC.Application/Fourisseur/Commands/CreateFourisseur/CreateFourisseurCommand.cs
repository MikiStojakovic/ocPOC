using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopartisOC.Application.Fourisseur.Commands.CreateFourisseur
{
    public class CreateFourisseurCommand : IRequest<Guid>
    {
        public Guid FourisseurId { get; set; }
        public string Name { get; set; }
    }
}
