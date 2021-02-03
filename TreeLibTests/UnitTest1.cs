using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using TreeLib;

namespace TreeLibTests
{
    [TestClass]
    public class TestBinaryTree
    {
        //[TestMethod]
        //public void T001_insertIntoNode()
        //{
        //    Node<string, int> root = new Node<string, int>("consider", 10);
        //    Node<string, int>.Insert(root, "full", 11);
        //    Assert.AreEqual("full", root.RightChild.Key);
        //    Assert.AreEqual(11, root.RightChild.Payload);
        //}

        //[TestMethod]
        //public void T002_insertIntoTree()
        //{
        //    BinaryTree<string, int> tree = new BinaryTree<string, int>();
        //    tree.Insert("consider", 10);
        //    tree.Insert("full", 11);
        //}

        //[TestMethod]
        //public void T003_HeightOfEmptyTree()
        //{
        //    BinaryTree<string, int> emptyTree = new BinaryTree<string, int>();
        //    Assert.AreEqual(-1, emptyTree.Height());
        //}

        //[TestMethod]
        //public void T004_InsertOneNodeTest()
        //{
        //    BinaryTree<string, int> tree = new BinaryTree<string, int>();
        //    tree.Insert("abc", 10);
        //    Assert.AreEqual(0, tree.Height());
        //}

        //[TestMethod]
        //public void T005_InsertTestThreeNodesTest()
        //{
        //    BinaryTree<string, int> tree = new BinaryTree<string, int>();
        //    tree.Insert("abc", 10);
        //    tree.Insert("bcd", 11);
        //    tree.Insert("cde", 12);
        //    Assert.AreEqual(2, tree.Height());
        //}

        //[TestMethod]
        //public void T006_heightTest()
        //{
        //    BinaryTree<string, int> tree = new BinaryTree<string, int>();
        //    tree.Insert("s", 10);
        //    tree.Insert("e", 10);
        //    tree.Insert("a", 10);
        //    tree.Insert("r", 10);
        //    tree.Insert("c", 10);
        //    tree.Insert("h", 10);
        //    tree.Insert("i", 10);
        //    Assert.AreEqual(4, tree.Height());
        //}

        //[TestMethod]
        //public void T007_traverseWithITraverse()
        //{
        //    BinaryTree<string, int> tree = new BinaryTree<string, int>();
        //    tree.Insert("j", 10);
        //    tree.Insert("d", 11);
        //    tree.Insert("r", 12);

        //    FindMaxTraversal<string, int> maxTraversal =
        //        new FindMaxTraversal<string, int>("j", 10);

        //    tree.InOrderTraversal(maxTraversal);

        //    Assert.AreEqual(12, maxTraversal.MaxPayload);
        //    Assert.AreEqual("r", maxTraversal.MaxKey);

        //    string[] result = new string[] { "d", "j", "r" };
        //    int resultIndex = 0;

        //    foreach (string nodeKey in maxTraversal.KeyList)
        //    {
        //        Assert.AreEqual(result[resultIndex++], nodeKey);
        //    }
        //}

        //[TestMethod]
        //public void T008_preOrdertraverseWithITraverse()
        //{
        //    BinaryTree<string, int> tree = new BinaryTree<string, int>();
        //    tree.Insert("j", 10);
        //    tree.Insert("d", 11);
        //    tree.Insert("r", 12);

        //    FindMaxTraversal<string, int> maxTraversal =
        //        new FindMaxTraversal<string, int>("j", 10);

        //    tree.PreOrderTraversal(maxTraversal);

        //    Assert.AreEqual(12, maxTraversal.MaxPayload);
        //    Assert.AreEqual("r", maxTraversal.MaxKey);

        //    string[] result = new string[] { "j", "d", "r" };
        //    int resultIndex = 0;

        //    foreach (string nodeKey in maxTraversal.KeyList)
        //    {
        //        Assert.AreEqual(result[resultIndex++], nodeKey);
        //    }
        //}

        //[TestMethod]
        //public void T009_postOrdertraverseWithITraverse()
        //{
        //    BinaryTree<string, int> tree = new BinaryTree<string, int>();
        //    tree.Insert("j", 10);
        //    tree.Insert("d", 11);
        //    tree.Insert("r", 12);

        //    FindMaxTraversal<string, int> maxTraversal =
        //        new FindMaxTraversal<string, int>("j", 10);

        //    tree.PostOrderTraversal(maxTraversal);

        //    Assert.AreEqual(12, maxTraversal.MaxPayload);
        //    Assert.AreEqual("r", maxTraversal.MaxKey);

        //    string[] result = new string[] { "d", "r", "j" };
        //    int resultIndex = 0;

        //    foreach (string nodeKey in maxTraversal.KeyList)
        //    {
        //        Assert.AreEqual(result[resultIndex++], nodeKey);
        //    }
        //}



        //// Print trees with the following grammar:
        //// "(" <root> <leftTree> <rightTree> ")"
        //// where <leftTree> and <rightTree> are not printed if they are both null.
        //[TestMethod]
        //public void T010_printNullTree()
        //{
        //    BinaryTree<string, int> tree = new BinaryTree<string, int>();
        //    Assert.AreEqual("()", tree.ToString());
        //}

        //[TestMethod]
        //public void T011_printSimpleTree()
        //{
        //    BinaryTree<string, int> tree = new BinaryTree<string, int>();
        //    tree.Insert("j", 10);
        //    tree.Insert("d", 11);
        //    tree.Insert("r", 12);

        //    Assert.AreEqual("(j (d) (r))", tree.ToString());
        //}

        //[TestMethod]
        //public void T012_printAlphabet()
        //{
        //    BinaryTree<string, int> tree = new BinaryTree<string, int>();
        //    tree.Insert("a", 10);
        //    tree.Insert("b", 11);
        //    tree.Insert("c", 12);

        //    Assert.AreEqual("(a () (b () (c)))", tree.ToString());
        //}

        //[TestMethod]
        //public void T013_printSearch()
        //{
        //    BinaryTree<string, int> tree = new BinaryTree<string, int>();
            
        //    tree.Insert("s", 10);
        //    Assert.AreEqual("(s)", tree.ToString());
        //    tree.Insert("e", 11);
        //    Assert.AreEqual("(s (e) ())", tree.ToString());
        //    tree.Insert("a", 12);
        //    Assert.AreEqual("(s (e (a) ()) ())", tree.ToString());
        //    tree.Insert("r", 13);
        //    Assert.AreEqual("(s (e (a) (r)) ())", tree.ToString());
        //    tree.Insert("c", 14);
        //    Assert.AreEqual("(s (e (a () (c)) (r)) ())", tree.ToString());
        //    tree.Insert("h", 15);
        //    Assert.AreEqual("(s (e (a () (c)) (r (h) ())) ())", tree.ToString());
        //}

        //[TestMethod]
        //public void T014_simpleRotateRight()
        //{
        //    BinaryTree<string, int> tree = new BinaryTree<string, int>();

        //    tree.Insert("s", 10);
        //    Assert.AreEqual("(s)", tree.ToString());
        //    tree.Insert("e", 11);
        //    Assert.AreEqual("(s (e) ())", tree.ToString());
        //    tree.RotateRight();
        //    Assert.AreEqual("(e () (s))", tree.ToString());
        //}

        //[TestMethod]
        //public void T015_simpleRotateLeft()
        //{
        //    BinaryTree<string, int> tree = new BinaryTree<string, int>();

        //    tree.Insert("s", 10);
        //    Assert.AreEqual("(s)", tree.ToString());
        //    tree.Insert("z", 11);
        //    Assert.AreEqual("(s () (z))", tree.ToString());
        //    tree.RotateLeft();
        //    Assert.AreEqual("(z (s) ())", tree.ToString());
        //}

        //[TestMethod]
        //public void T016_moreRotateLeft()
        //{
        //    BinaryTree<string, int> tree = new BinaryTree<string, int>();

        //    tree.Insert("m", 10);
        //    tree.Insert("f", 11);
        //    tree.Insert("t", 11);
        //    tree.Insert("c", 11);
        //    tree.Insert("j", 11);
        //    tree.Insert("t", 11);
        //    tree.Insert("q", 11);
        //    tree.Insert("w", 11);
        //    Assert.AreEqual("(m (f (c) (j)) (t (q) (w)))", tree.ToString());
        //    tree.RotateLeft();
        //    Assert.AreEqual("(t (m (f (c) (j)) (q)) (w))", tree.ToString());
        //}

        //[TestMethod]
        //public void T017_moreRotateRight()
        //{
        //    BinaryTree<string, int> tree = new BinaryTree<string, int>();

        //    tree.Insert("m", 10);
        //    tree.Insert("f", 11);
        //    tree.Insert("t", 11);
        //    tree.Insert("c", 11);
        //    tree.Insert("j", 11);
        //    tree.Insert("t", 11);
        //    tree.Insert("q", 11);
        //    tree.Insert("w", 11);
        //    Assert.AreEqual("(m (f (c) (j)) (t (q) (w)))", tree.ToString());
        //    tree.RotateRight();
        //    Assert.AreEqual("(f (c) (m (j) (t (q) (w))))", tree.ToString());
        //}

        //[TestMethod]
        //public void T018_insertAtRoot()
        //{
        //    BinaryTree<string, int> tree = new BinaryTree<string, int>();

        //    tree.InsertAtRoot("s", 10);
        //    Assert.AreEqual("(s)", tree.ToString());
        //    tree.InsertAtRoot("e", 11);
        //    Assert.AreEqual("(e () (s))", tree.ToString());
        //    tree.InsertAtRoot("a", 12);
        //    Assert.AreEqual("(a () (e () (s)))", tree.ToString());
        //    tree.InsertAtRoot("r", 13);
        //    Assert.AreEqual("(r (a () (e)) (s))", tree.ToString());
        //    tree.InsertAtRoot("c", 14);
        //    Assert.AreEqual("(c (a) (r (e) (s)))", tree.ToString());
        //    tree.InsertAtRoot("h", 15);
        //    Assert.AreEqual("(h (c (a) (e)) (r () (s)))", tree.ToString());
        //}

        //// Extra Credit
        //[TestMethod]
        //public void T019_enumerationInOrder()
        //{
        //    BinaryTree<string, int> tree = new BinaryTree<string, int>();
        //    tree.Insert("j", 10);
        //    tree.Insert("d", 11);
        //    tree.Insert("r", 12);

        //    string[] result = new string[] { "d", "j", "r" };
        //    int resultIndex = 0;

        //    foreach (string nodeKey in tree.InOrder())
        //    {
        //        Assert.AreEqual(result[resultIndex++], nodeKey);
        //    }

        //}
    }
}
