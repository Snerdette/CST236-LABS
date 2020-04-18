using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCollections;

namespace UnitTests
{
    [TestClass]
    public class StackUpUT
    {
        [TestMethod]
        public void TestConstructor()
        {
            StackUp<string> stack = new StackUp<string>();
            Assert.AreEqual(stack.Count, 0);
        }

        [TestMethod]
        public void TestGetCount()
        {
            StackUp<string> stack = new StackUp<string>();
            Assert.AreEqual(stack.Count, 0);
            stack.Push("get_Count");
            Assert.AreEqual(1, stack.Count);
        }

        [TestMethod]
        public void TestPush()
        {
            StackUp<string> stack = new StackUp<string>();
            stack.Push("hello");
            Assert.AreEqual(1, stack.Count);
        }

        [TestMethod]
        public void TestPushPops()
        {
            StackUp<string> stack = new StackUp<string>();
            stack.Push("Hello");
            stack.Push("Hi");
            stack.Push("Howdy");
            stack.Push("Bonjour");
            Assert.AreEqual(4, stack.Count);
            Assert.AreEqual("Bonjour", stack.Pop());
            Assert.AreEqual("Howdy", stack.Pop());
            Assert.AreEqual("Hi", stack.Pop());
            Assert.AreEqual("Hello", stack.Pop());
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void TestPop()
        {
            StackUp<string> stack = new StackUp<string>();
            Assert.AreEqual(0, stack.Count);
            stack.Push("hello");
            Assert.AreEqual(1, stack.Count);
            string s = stack.Pop();
            Assert.AreEqual("hello", s);
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(StackEmptyException))]
        public void TestPopEmpty()
        {
            StackUp<string> stack = new StackUp<string>();
            Assert.AreEqual(0, stack.Count);
            stack.Pop();
            //Assert.ThrowsException<StackEmptyException>(() => { stack.Pop(); });         
        }

        [TestMethod]
        public void TestPeek()
        {
            StackUp<string> stack = new StackUp<string>(); 
            stack.Push("Peek");
            string s = stack.Peek();
            Assert.AreEqual("Peek", s);
        }

        [TestMethod]
        [ExpectedException(typeof(StackEmptyException))]
        public void TestPeekEmpty()
        { 
            StackUp<string> stack = new StackUp<string>();
            Assert.AreEqual(0, stack.Count);
            stack.Peek();      
        }
    }
}
