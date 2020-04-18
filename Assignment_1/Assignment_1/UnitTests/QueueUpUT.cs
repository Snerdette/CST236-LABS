using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCollections;

namespace UnitTests
{
    [TestClass]
    public class QueueUpUT
    {
        [TestMethod]
        public void TestConstructor()
        {
            QueueUp<int> queue = new QueueUp<int>();
            Assert.AreEqual(0, queue.Count);
        }

        [TestMethod]
        public void TestCount()
        {
            QueueUp<int> queue = new QueueUp<int>();
            Assert.AreEqual(0, queue.Count);
            queue.Insert(42);
            Assert.AreEqual(1, queue.Count);
        }

        [TestMethod]
        public void TestInsert()
        {
            QueueUp<int> queue = new QueueUp<int>();
            Assert.AreEqual(0, queue.Count);
            queue.Insert(42);
            Assert.AreEqual(1, queue.Count);
            queue.Insert(64);
            Assert.AreEqual(2, queue.Count);
            queue.Insert(22);
            Assert.AreEqual(3, queue.Count);
            queue.Insert(12);
            Assert.AreEqual(4, queue.Count);
        }

        [TestMethod]
        public void TestRemove()
        {
            QueueUp<int> queue = new QueueUp<int>();            
            queue.Insert(42);       
            queue.Insert(101);          
            queue.Insert(33);

            Assert.AreEqual(3, queue.Count);
            Assert.AreEqual(42, queue.Remove());
            Assert.AreEqual(2, queue.Count);
            Assert.AreEqual(101, queue.Remove());
            Assert.AreEqual(1, queue.Count);
            Assert.AreEqual(33, queue.Remove());
            Assert.AreEqual(0, queue.Count);

            // Test that we can insert things after we emptied the queue
            queue.Insert(200);
            Assert.AreEqual(1, queue.Count);
            Assert.AreEqual(200, queue.Remove());
            queue.Insert(201);
            queue.Insert(202);
            Assert.AreEqual(2, queue.Count);
            Assert.AreEqual(201, queue.Remove());
            Assert.AreEqual(1, queue.Count);
            Assert.AreEqual(202, queue.Remove());

        }

        [TestMethod]
        public void TestPeek()
        {
            QueueUp<int> queue = new QueueUp<int>();
            queue.Insert(42);
            Assert.AreEqual(42, queue.Peek());
            queue.Insert(33);
            Assert.AreEqual(42, queue.Peek());
            Assert.AreEqual(42, queue.Remove());
            Assert.AreEqual(33, queue.Peek());
        }

        [TestMethod]
        public void TestPeekEmpty()
        {
            QueueUp<int> queue = new QueueUp<int>();
            Assert.ThrowsException<QueueEmptyException>(() => { queue.Peek(); });

        }

        [TestMethod]
        public void TestRemoveEmpty()
        {
            QueueUp<int> queue = new QueueUp<int>();
            Assert.ThrowsException<QueueEmptyException>(() => { queue.Remove(); });

        }
    }
}
