namespace Search.Net
{
    readonly public struct Leaf<T>
    {
        public Leaf(ref DataLeaf<T>[] dataLeaves){
            DataLeaves = dataLeaves;
        }

        private DataLeaf<T>[] DataLeaves { get; }
        public ref readonly DataLeaf<T> this[ushort Char] => ref DataLeaves[Char - 97];
    }
}
