using System;
using System.Collections.Generic;

namespace MugShot.Lib.MediaTypes
{
    public class Png : MediaType, IMediaType
    {
        public String Name
        {
            get { return "PNG Image"; }
        }

        public String Description 
        {
            get { return "Portable Network Graphics - Very common image format"; }
        }

        public String[] FileExtensions
        {
            get
            {
                return new string[] { "png" };
            }
        }

        public bool ExtractMetaData()
        {
            throw new NotImplementedException();
        }
    }
}