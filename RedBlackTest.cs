using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TreeLib;

// Additional tests for lab 3
// 
namespace TreeLibTests
{
    [TestClass]
    public class RedBlackTest
    {
        // Modify the Node class so that it contains the boolean property
        // IsRed.
        // Modify the Node constructor to take a 3rd parameter (isRed)
        // The default for the parameter should be false.  That will
        // make it compatible with all the code that you have already written.

        // You will have to modify the Rotate functions to swap the
        // colors of the two nodes (root and child) that are being 
        // rotated.

        // Write a RedBlackInsert function for tree
        [TestMethod]
        public void T001_InsertRedBlackRoot()
        {
            BinaryTree<string, int> tree = new BinaryTree<string, int>();
            tree.RedBlackInsert("a", 10);
            Assert.AreEqual(0, tree.Height());
        }

        // Modify the BinaryTree class ToString function so that 
        // it places an astrisk after the names of nodes that are red.

        [TestMethod]
        public void T002_InsertRedBlackLeft()
        {
            BinaryTree<string, int> tree = new BinaryTree<string, int>();
            tree.RedBlackInsert("m", 10);
            tree.RedBlackInsert("a", 11);
            Assert.AreEqual(1, tree.Height());
            Assert.AreEqual("(m (a*) ())", tree.ToString());
        }


        [TestMethod]
        public void T003_InsertRedBlackRight()
        {
            BinaryTree<string, int> tree = new BinaryTree<string, int>();
            tree.RedBlackInsert("m", 10);
            tree.RedBlackInsert("r", 11);
            Assert.AreEqual("(r (m*) ())", tree.ToString());
        }
        // end T003_InsertRedBlackRight()

        [TestMethod]
        public void T004_InsertSerachlg()
        {
            BinaryTree<string, int> tree = new BinaryTree<string, int>();
            tree.RedBlackInsert("s", 10);
            Assert.AreEqual("(s)", tree.ToString());
            tree.RedBlackInsert("e", 10);
            Assert.AreEqual("(s (e*) ())", tree.ToString());
            tree.RedBlackInsert("a", 10);
            Assert.AreEqual("(e (a) (s))", tree.ToString());
            tree.RedBlackInsert("r", 10);
            Assert.AreEqual("(e (a) (s (r*) ()))", tree.ToString());
            tree.RedBlackInsert("c", 10);
            Assert.AreEqual("(e (c (a*) ()) (s (r*) ()))", tree.ToString());
            tree.RedBlackInsert("h", 10);
            Assert.AreEqual("(r (e* (c (a*) ()) (h)) (s))", tree.ToString());
            tree.RedBlackInsert("l", 10);
            Assert.AreEqual("(r (e* (c (a*) ()) (l (h*) ())) (s))", tree.ToString());
            tree.RedBlackInsert("g", 10);
            Assert.AreEqual("(h (e (c (a*) ()) (g)) (r (l) (s)))", tree.ToString());
        }

         [TestMethod]
        public void T005_InsertAlphabet()
        {
            BinaryTree<string, int> tree = new BinaryTree<string, int>();
            tree.RedBlackInsert("a", 10);
            tree.RedBlackInsert("b", 10);
            tree.RedBlackInsert("c", 10);
            tree.RedBlackInsert("d", 10);
            tree.RedBlackInsert("e", 10);
            tree.RedBlackInsert("f", 10);
            tree.RedBlackInsert("g", 10);
            tree.RedBlackInsert("h", 10);
            tree.RedBlackInsert("i", 10);
            tree.RedBlackInsert("j", 10);
            tree.RedBlackInsert("k", 10);
            tree.RedBlackInsert("l", 10);
            tree.RedBlackInsert("m", 10);
            tree.RedBlackInsert("n", 10);
            tree.RedBlackInsert("o", 10);
            string expected = 
                "(h (d (b (a) (c)) (f (e) (g))) (l (j (i) (k)) (n (m) (o))))";
            Assert.AreEqual(expected,
                tree.ToString());
            tree.RedBlackInsert("p", 10);
            tree.RedBlackInsert("q", 10);
            tree.RedBlackInsert("r", 10);
            tree.RedBlackInsert("s", 10);
            tree.RedBlackInsert("t", 10);
            tree.RedBlackInsert("u", 10);
            tree.RedBlackInsert("v", 10);
            tree.RedBlackInsert("w", 10);
            tree.RedBlackInsert("x", 10);
            tree.RedBlackInsert("y", 10);
            tree.RedBlackInsert("z", 10);
            expected =
                "(p (h* (d (b (a) (c)) (f (e) (g))) (l (j (i) (k)) " +
                "(n (m) (o)))) (t (r (q) (s)) (x (v* (u) (w)) (z (y*) ()))))";
            Assert.AreEqual(expected, tree.ToString());
        }
    }
}
