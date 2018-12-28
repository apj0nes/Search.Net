namespace Search.Net
{
    readonly public struct Root<T>
    {
        public Root(Node<T>[] childNodes)
        {
            ChildNodes = childNodes;
        }

        public Node<T>[] ChildNodes { get; }
    }
}
