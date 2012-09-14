using System.Collections;
using System.Collections.Generic;

namespace MugShot.Lib.MetaDataReaders.Exif
{
    //
    // dont touch this class. its for IEnumerator
    // 
    //
    internal class ReaderEnumerator : IEnumerator
    {
        private Hashtable exifTable;
        private IDictionaryEnumerator index;

        internal ReaderEnumerator(Hashtable exif)
        {
            exifTable = exif;
            Reset();
            index = exif.GetEnumerator();
        }

        #region IEnumerator Members

        public void Reset()
        {
            index = null;
        }

        public object Current
        {
            get
            {
                KeyValuePair<string, string> kvp = new KeyValuePair<string, string>(index.Key.ToString(), index.Value.ToString());
                return kvp;
            }
        }

        public bool MoveNext()
        {
            if (index != null && index.MoveNext())
                return true;
            else
                return false;
        }

        #endregion
    }
}