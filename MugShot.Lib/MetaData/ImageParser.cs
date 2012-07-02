using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using MugShot.Utilities.Exif;

namespace MugShot.Lib.MetaData
{
    class ImageParser : IMetaDataParser
    {
        public ArrayList Parse(ref object image)
        {
            Bitmap bmp = (Bitmap) image;
            MugShot.Utilities.Exif.Reader exif = new MugShot.Utilities.Exif.Reader(ref bmp);
            return GetExifKvp(exif);
        }

        public ArrayList Parse(string imagePath)
        {
            throw new NotImplementedException();
        }

        private ArrayList GetExifKvp(MugShot.Utilities.Exif.Reader exif)
        {
            ArrayList kvp = new ArrayList();
            foreach (KeyValuePair<string, string> s in exif)
            {
                KeyValuePair<string, string> record = new KeyValuePair<string, string>(s.Key, s.Value);
                kvp.Add(record);
            }
            return kvp;
        }
    }
}
