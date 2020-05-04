using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopartisOC.Application.Conseiller.Commands.DeleteConseiller
{
    public class DeleteConseillerCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
