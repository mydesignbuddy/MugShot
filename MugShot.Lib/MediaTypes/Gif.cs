using System;
using System.Collections.Generic;

namespace MugShot.Lib.MediaTypes
{
    public class Gif : MediaType, IMediaType
    {
        public String Name
        {
            get { return "GIF Image"; }
        }

        public String Description 
        {
            get { return "Graphics Interchange Format - Very common image format"; }
        }

        public String[] FileExtensions
        {
            get
            {
                return new string[] { "gif" };
            }
        }

        public bool ExtractMetaData()
        {
            throw new NotImplementedException();
        }
    }
}