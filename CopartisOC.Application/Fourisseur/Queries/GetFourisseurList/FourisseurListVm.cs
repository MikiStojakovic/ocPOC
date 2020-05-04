using System;
using System.Collections.Generic;
using System.Text;

namespace CopartisOC.Application.Fourisseur.Queries.GetFourisseurList
{
    public class FourisseurListVm
    {
        public IList<FourisseurDto> Fourisseurs { get; set; }

        public bool CreateEnabled { get; set; }
    }
}
