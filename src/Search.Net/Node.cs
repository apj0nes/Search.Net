namespace Search.Net
{
    readonly public struct Node<T>
    {
        public Node(ushort Char, Leaf<T>[] leaves)
        {
            this.Char = Char;
            Leaves = leaves;
        }
        public ushort Char { get; }
        public Leaf<T>[] Leaves { get; }
    }
}
