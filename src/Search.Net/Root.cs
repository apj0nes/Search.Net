namespace Search.Net
{
    readonly public struct Root<T>
    {
        public Root(ref Node<T>[] childNodes){
            ChildNodes = childNodes;
        }

        private Node<T>[] ChildNodes { get; }

        public ref readonly Node<T> this[ushort Char] => ref ChildNodes[Char - 97];
    }
}
