using System;
using System.Collections.Generic;
using System.Text;

namespace CopartisOC.Application.OuvertureCompte.Queries.GetOuvertureCompteListByConseiller
{
    public class OuvertureCompteListVm
    {
        public IList<OuvertureCompteByConseillerDto> OuvertureComptes { get; set; }

        public bool CreateEnabled { get; set; }
    }
}
