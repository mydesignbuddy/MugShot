using System;
using System.Collections;
using System.Collections.Generic;

namespace MugShot.Lib.MediaTypes
{
    public interface IMediaType
    {
        String Name { get;}
        String Description { get; }
        String[] FileExtensions { get; }
        ArrayList MetaData { get; set; }
        Boolean ExtractMetaData();
    }
}
