using System.Collections.Generic;

namespace Search.Net
{
    public struct DataLeaf<T>
    {
        public DataLeaf(ushort Char)
        {
            this.Char = Char;
        }

        public ushort Char { get; }
        private static HashSet<T> data = new HashSet<T>();

        public ref HashSet<T> Data => ref data;
    }
}
