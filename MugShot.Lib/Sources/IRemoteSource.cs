using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MugShot.Lib.Sources
{
    interface IRemoteSource : ISource
    {
        string Host { get; set; }
        string UserId { get; set; }
        string Password { get; set; }

        Boolean Authenticate();
    }
}
