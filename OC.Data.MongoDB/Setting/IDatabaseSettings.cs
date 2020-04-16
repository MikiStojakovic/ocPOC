using MongoDB.Driver;
using OC.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OC.Data.MongoDB.Setting
{
    public interface IDatabaseSettings
    {
        IMongoCollection<Prospect> Prospects { get;  }
    }
}
