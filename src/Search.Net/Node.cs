namespace Search.Net
{
    readonly public struct Node<T>
    {
        public Node(ref Leaf<T>[] leaves){
            Leaves = leaves;
        }

        private Leaf<T>[] Leaves { get; }

        public ref readonly Leaf<T> this[ushort Char] => ref Leaves[Char - 97];
    }
}
