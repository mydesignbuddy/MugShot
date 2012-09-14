using System;
using System.Collections.Generic;

namespace MugShot.Lib.Media
{
    public class Png : ImageMedia, IMedia
    {
        public new String Name
        {
            get { return "PNG Image"; }
        }

        public new String Description 
        {
            get { return "Portable Network Graphics - Very common image format"; }
        }

        public new String[] FileExtensions
        {
            get
            {
                return new string[] { "png" };
            }
        }
    }
}