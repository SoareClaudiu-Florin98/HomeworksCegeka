using MongoDB.Driver;
using RepositoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern
{
        public class MongoDbRepository<TEntity> : IRepository<TEntity>
    where TEntity : class, IEntity
        {
            private readonly IMongoDatabase database;
            private IMongoCollection<TEntity> collection => database.GetCollection<TEntity>(typeof(TEntity).Name);

            public MongoDbRepository()
            {
                var dbClient = new MongoClient("__ADD__HERE__");
                database = dbClient.GetDatabase("CarDealership");
            }

            public void Insert(TEntity entity)
            {
                collection.InsertOne(entity);
            }

            public TEntity GetById(Guid Id)
            {
                return collection.Find(e => e.Id == Id).SingleOrDefault();
            }

            public IEnumerable<TEntity> GetByAll()
            {
                return collection.Find(e => true).ToEnumerable();
            }

            public void Delete(TEntity entity)
            {
                collection.DeleteOne(e => e.Id == entity.Id);
            }

            public void Update(TEntity entity)
            {
                collection.ReplaceOne(e => e.Id == entity.Id, entity);
            }
        }
}

