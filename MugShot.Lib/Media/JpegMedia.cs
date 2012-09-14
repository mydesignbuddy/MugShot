using System;

namespace MugShot.Lib.Media
{
    public class JpegMedia : ImageMedia, IMedia
    {
        public new String Name
        {
            get { return "JPEG Image"; }
        }

        public new String Description 
        {
            get { return "Joint Photographic Experts Group - Very common image format"; }
        }

        public new String[] FileExtensions
        {
            get
            {
                return new string[] { "jpg", "jpeg", "jpe", "jfif", "jif" };
            }
        }
    }
}