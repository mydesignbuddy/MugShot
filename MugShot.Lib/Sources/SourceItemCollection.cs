using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MugShot.Lib.Sources
{
    class SourceItemCollection : ICollection<ISourceItem>
    {
        public IEnumerator<ISourceItem> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(ISourceItem item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(ISourceItem item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(ISourceItem[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(ISourceItem item)
        {
            throw new NotImplementedException();
        }

        public int Count { get; private set; }
        public bool IsReadOnly { get; private set; }
    }
}
