using System;
using System.Collections.Generic;
using System.Text;

namespace CopartisOC.Domain.Entities
{
    public class Prospect
    {        
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid ConseillerId { get; set; }
    }
}
