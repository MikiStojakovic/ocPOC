using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopartisOC.Application.Conseiller.Commands.CreateConseiller
{
    public class CreateConseillerCommand : IRequest<Guid>
    {
        public string Code { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Guid FourisseurId { get; set; }
    }
}
