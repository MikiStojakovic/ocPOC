﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopartisOC.Application.Conseiller.Commands.CreateConseiller
{
    public class CreateConseillerCommand : IRequest<Guid>
    {
        public Guid ConseillerId { get; set; }
        public string Code { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Guid FourisseurId { get; set; }
    }
}
