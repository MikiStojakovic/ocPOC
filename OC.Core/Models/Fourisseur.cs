﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace OC.Core.Models
{
    public class Fourisseur
    {
        public Fourisseur()
        {
            Conseillers = new Collection<Conseiller>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Conseiller> Conseillers { get; set; }
    }
}
