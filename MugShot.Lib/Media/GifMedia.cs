using System;

namespace MugShot.Lib.Media
{
    public class GifMedia : ImageMedia, IMedia
    {
        public new String Name
        {
            get { return "GIF Image"; }
        }

        public new String Description 
        {
            get { return "Graphics Interchange Format - Very common image format"; }
        }

        public new String[] FileExtensions
        {
            get
            {
                return new string[] { "gif" };
            }
        }
    }
}