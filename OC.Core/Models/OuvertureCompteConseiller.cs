using System;
using System.Collections.Generic;
using System.Text;

namespace OC.Core.Models
{
    public class OuvertureCompteConseiller
    {
        public Guid Id { get; set; }
        public Guid ConseillerId { get; set; }
        public Guid OuvertureCompteId { get; set; }
    }
}
