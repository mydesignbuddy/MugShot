using System.Collections;

namespace MugShot.Lib.Media
{
    public class BaseMedia : IMedia
    {
        public string Name { get; private set; }

        public string Description { get; private set; }

        public string[] FileExtensions { get; private set; }

        public ArrayList MetaData { get; set; }

        public bool ExtractMetaData()
        {
            throw new System.NotImplementedException();
        }
    }
}
