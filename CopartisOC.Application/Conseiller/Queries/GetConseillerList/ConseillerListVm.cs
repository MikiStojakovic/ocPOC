using System;
using System.Collections.Generic;
using System.Text;

namespace CopartisOC.Application.Conseiller.Queries.GetConseillerList
{
    public class ConseillerListVm
    {
        public IList<ConseillerDto> Conseillers { get; set; }

        public bool CreateEnabled { get; set; }
    }
}
