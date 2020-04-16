using Microsoft.Extensions.Options;
using MongoDB.Driver;
using OC.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OC.Data.MongoDB.Setting
{
    public class DatabaseSetting : IDatabaseSettings
    {
        private readonly IMongoDatabase _db;

        public DatabaseSetting(IOptions<Settings> options, IMongoClient client)
        {
            _db = client.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<Prospect> Prospects => _db.GetCollection<Prospect>("Prospects");
    }
}
