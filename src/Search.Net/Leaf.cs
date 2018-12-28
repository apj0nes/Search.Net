namespace Search.Net
{
    readonly public struct Leaf<T>
    {
        public Leaf(ushort Char, DataLeaf<T>[] dataLeaves)
        {
            this.Char = Char;
            DataLeaves = dataLeaves;
        }

        public ushort Char { get; }
        public DataLeaf<T>[] DataLeaves { get; }
    }
}
