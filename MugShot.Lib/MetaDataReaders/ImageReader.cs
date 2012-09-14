using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using MugShot.Lib.MetaDataReaders.Exif;

namespace MugShot.Lib.MetaDataReaders
{
    class ImageReader : IMetaDataReader
    {
        public ArrayList Parse(ref object image)
        {
            Bitmap bmp = (Bitmap) image;
            Reader exif = new Reader(ref bmp);
            return GetExifKvp(exif);
        }

        public ArrayList Parse(string imagePath)
        {
            throw new NotImplementedException();
        }

        private ArrayList GetExifKvp(Reader exif)
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
