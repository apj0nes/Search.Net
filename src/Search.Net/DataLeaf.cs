using System.Collections.Generic;

namespace Search.Net
{
    public struct DataLeaf<T>
    {
        private static HashSet<T> data = new HashSet<T>();

        public ref HashSet<T> Data => ref data;
    }
}
