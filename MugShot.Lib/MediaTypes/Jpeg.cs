using System;
using System.Collections.Generic;
using MugShot.Lib.MediaTypes;

namespace MugShot.Lib.MediaTypes
{
    public class Jpeg : MediaType, IMediaType
    {
        public String Name
        {
            get { return "JPEG Image"; }
        }

        public String Description 
        {
            get { return "Joint Photographic Experts Group - Very common image format"; }
        }

        public String[] FileExtensions
        {
            get
            {
                return new string[] { "jpg", "jpeg", "jpe", "jfif", "jif" };
            }
        }

        public bool ExtractMetaData()
        {
            throw new NotImplementedException();
        }
    }
}