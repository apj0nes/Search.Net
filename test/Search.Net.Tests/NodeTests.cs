using Xunit;

namespace Search.Net.Tests
{
    public class NodeTests
    {
        [Fact]
        public void foo()
        {
            Node<int>[] nodes = new Node<int>[26];
            for (char level1Char = 'a'; level1Char <= 'z'; level1Char++)
            {
                Leaf<int>[] leaves = new Leaf<int>[26];
                for (char level2Char = 'a'; level2Char <= 'z'; level2Char++)
                {
                    var dataLeaves = new DataLeaf<int>[26];
                    for (char level3Char = 'a'; level3Char <= 'z'; level3Char++)
                    {
                        dataLeaves[level3Char - 97] = new DataLeaf<int>(level3Char);
                    }
                    leaves[level2Char - 97] = new Leaf<int>(level2Char, dataLeaves);
                }
                nodes[level1Char - 97] = new Node<int>(level1Char, leaves);
            }

            var trigramTree = new Root<int>(nodes);

            trigramTree.ChildNodes[0].Leaves[0].DataLeaves[0].Data.Add(1);

            Assert.Contains(1, trigramTree.ChildNodes[0].Leaves[0].DataLeaves[0].Data);
        }
    }
}
