using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MugShot.Lib.Media;

namespace MugShot.Lib.Sources
{
    class FtpSource: IRemoteSource
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int RecursiveLevel { get; set; }

        public string Host { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }

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

        public bool Authenticate()
        {
            throw new NotImplementedException();
        }
    }
}
