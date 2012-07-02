using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MugShot.Lib.MetaData
{
    interface IMetaDataParser
    {
        ArrayList Parse(ref object obj);
        ArrayList Parse(string filePath);
    }
}
