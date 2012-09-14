using System;
using System.Collections;

namespace MugShot.Lib.Media
{
    public interface IMedia
    {
        String Name { get;}
        String Description { get; }
        String[] FileExtensions { get; }
        ArrayList MetaData { get; set; }
        Boolean ExtractMetaData();
    }
}
