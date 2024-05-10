using Solution.BST;

namespace Solution.Tests;

[TestClass()]
public class BinarySearchTreeTests
{
    private BinarySearchTree bst;

    [TestInitialize]
    public void Initialize()
    {
        bst = new BinarySearchTree();
        int[] values = { 15, 10, 20, 5, 12, 18, 25 };
        foreach (int value in values)
        {
            bst.Insert(value);
        }
    }

    [TestMethod]
    public void Insert_DuplicateValue_ThrowsException()
    {
        var bst = new BinarySearchTree();
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(20);

        // Tes memasukkan duplikat, harusnya melempar exception
        Assert.ThrowsException<InvalidOperationException>(() => bst.Insert(10), "Expected an InvalidOperationException for a duplicate insertion.");
    }

    [TestMethod()]
    public void InsertTest_CheckRoot()
    {
        Assert.AreEqual("[5, 10, 12, 15, 18, 20, 25]", bst.Display());
    }

    [TestMethod()]
    public void InorderTraversalTest()
    {
        string expected = "[5, 10, 12, 15, 18, 20, 25]";
        Assert.AreEqual(expected, bst.InorderTraversal());
    }

    [TestMethod()]
    public void BreadthFirstTraversalTest()
    {
        string expected = "[15, 10, 20, 5, 12, 18, 25]";
        Assert.AreEqual(expected, bst.BreadthFirstTraversal());
    }

    [TestMethod()]
    public void PreorderTraversalTest()
    {
        string expected = "[15, 10, 5, 12, 20, 18, 25]";
        Assert.AreEqual(expected, bst.PreorderTraversal());
    }

    [TestMethod()]
    public void PostorderTraversalTest()
    {
        string expected = "[5, 12, 10, 18, 25, 20, 15]";
        Assert.AreEqual(expected, bst.PostorderTraversal());
    }

    [TestMethod()]
    public void FindMinimumTest()
    {
        Assert.AreEqual(5, bst.FindMinimum());
    }

    [TestMethod()]
    public void FindMaximumTest()
    {
        Assert.AreEqual(25, bst.FindMaximum());
    }

    [TestMethod()]
    [ExpectedException(typeof(Exception), "The tree is empty.")]
    public void FindMinimum_EmptyTree_ThrowsException()
    {
        var emptyTree = new BinarySearchTree();
        var min = emptyTree.FindMinimum();
    }

    [TestMethod()]
    [ExpectedException(typeof(Exception), "The tree is empty.")]
    public void FindMaximum_EmptyTree_ThrowsException()
    {
        var emptyTree = new BinarySearchTree();
        var max = emptyTree.FindMaximum();
    }
}
