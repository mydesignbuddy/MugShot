using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
using MugShot.Lib.Media;

namespace MugShot.Lib.DataStorages
{
    class MongoDbDataStorage : IDataStorage
    {
        private MongoServer _server;
        private string _connectionString;

        public MongoDbDataStorage()
        {
            GetInstance();
        }
        private void GetInstance()
        {
            _connectionString = "mongodb://localhost/?safe=true";
            _server = MongoServer.Create(_connectionString);
        }

        private MongoServer GetConnection()
        {
            return _server;
        }

        public string Name { get { return "MongoDB Storage"; } set { } }
        public string Description { get { return "Database Storage for NoSQL document-based database called MongoDB"; } set { } }
        public int RecursiveLevel { get; set; }
        public void Create(IMedia media)
        {
            throw new NotImplementedException();
        }

        public void Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, IMedia media)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Index()
        {
            throw new NotImplementedException();
        }

        public void Index(int startNum, int limit)
        {
            throw new NotImplementedException();
        }
    }
}
