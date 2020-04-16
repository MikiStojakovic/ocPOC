using MongoDB.Bson;
using MongoDB.Driver;
using OC.Core.Models;
using OC.Core.Repositories;
using OC.Data.MongoDB.Setting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OC.Data.MongoDB.Repositories
{
    public class ProspectRepository : IProspectRepository
    {
        private readonly IDatabaseSettings _context;
        public ProspectRepository(IDatabaseSettings context)
        {
            _context = context;
        }

        public async Task<Prospect> Create(Prospect prospect)
        {
            await _context.Prospects.InsertOneAsync(prospect);
            return prospect;
        }

        public async Task<bool> Delete(string id)
        {
            ObjectId idMongo = new ObjectId(id);
            FilterDefinition<Prospect> filter = Builders<Prospect>.Filter.Eq(p => p.Id, idMongo);

            DeleteResult deleteResult = await _context.Prospects.DeleteOneAsync(filter);

            return deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0;
        }

        public async Task<IEnumerable<Prospect>> GetAllProspect()
        {
            return await _context.Prospects.Find(x => true).ToListAsync(); //Check do we need Find(x => true)
        }

        public async Task<IEnumerable<Prospect>> GetAllProspectByConseillerId(Guid conseillerId)
        {
            ObjectId conseillerIdMongo = new ObjectId(conseillerId.ToString());
            FilterDefinition<Prospect> filter = Builders<Prospect>.Filter.Eq(pr => pr.ConseillerId, conseillerId);

            return await _context.Prospects.Find(filter).ToListAsync();
        }

        public async Task<Prospect> GetProspectById(Guid id)
        {
            ObjectId idMongo = new ObjectId(id.ToString());
            FilterDefinition<Prospect> filter = Builders<Prospect>.Filter.Eq(pr => pr.Id, idMongo);

            return await _context.Prospects.Find(filter).FirstOrDefaultAsync();
        }

        public void Update(string id, Prospect prospect)
        {
            ObjectId idMongo = new ObjectId(id.ToString());
            FilterDefinition<Prospect> filter = Builders<Prospect>.Filter.Eq(pr => pr.Id, idMongo);
            var update = Builders<Prospect>.Update.Set("FirstName", prospect.FirstName)
                                                    .Set("LastName", prospect.LastName)
                                                    .Set("ConseillerId", prospect.ConseillerId);

            _context.Prospects.FindOneAndUpdate(filter, update);
        }
    }
}
