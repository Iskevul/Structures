using Microsoft.VisualStudio.TestTools.UnitTesting;
using Structures;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDynArrayConstructors()
        {
            var arr1 = new DynArray();

            var arr2 = new DynArray();
           
            CollectionAssert.AreEquivalent(arr1.GetArray(), arr2.GetArray());
        }

        [TestMethod]
        public void TestDynArrayPushBack()
        {
            var arr1 = new DynArray();
            arr1.PushBack(1);

            var arr2 = new DynArray();
            arr2.PushBack(1);

            Assert.AreEqual(arr1.GetLength(), arr2.GetLength());
        }

        [TestMethod]
        public void TestDynArrayResizing()
        {
            DynArray temp = new DynArray(5);
            DynArray temp1 = new DynArray(5);
            temp1.Resize(11);

            Assert.AreEqual(temp.GetLength(), temp1.GetLength());
        }

        [TestMethod]
        public void TestDynArrayInsertAndPopBack()
        {
            var arr1 = new DynArray();
            arr1.Insert(1, 2);
            arr1.Insert(2, 3);

            var arr2 = new DynArray();
            arr2.Insert(1, 2);
            arr2.Insert(2, 4);

            CollectionAssert.AreEquivalent(arr1.GetArray(), arr2.GetArray());

            arr1.PopBack();
            arr2.PopBack();

            CollectionAssert.AreEquivalent(arr1.GetArray(), arr2.GetArray());
        }

        [TestMethod]
        public void TestDynArrayFillRandom()
        {
            var arr1 = new DynArray(5);
            var arr2 = new DynArray(5);

            arr1.FillRandom(2, 5);
            arr2.FillRandom(3, 7);

            CollectionAssert.AreNotEquivalent(arr1.GetArray(), arr2.GetArray());
        }

        [TestMethod]
        public void TestDynArrayDelete()
        {
            DynArray arr1 = new DynArray(5);
            DynArray arr2 = new DynArray(5);

            arr1.Delete(2);

            Assert.AreNotEqual(arr1.GetLength(), arr2.GetLength());
        }

        [TestMethod]
        public void TestQueue()
        {
            var queue = new MyQueue();

            queue.Push(1);

            Assert.AreEqual(queue.GetArray().GetLength(), 1);

            queue.Pop();

            Assert.AreEqual(queue.GetArray().GetLength(), 0);

            Assert.IsTrue(queue.IsEmpty());
        }

        [TestMethod]
        public void TestPushQueue()
        {
            var queue1 = new MyQueue();
            var queue2 = new MyQueue();

            queue1.Push(1);
            queue2.Push(2);

            CollectionAssert.AreNotEquivalent(queue1.GetArray().GetArray(), queue2.GetArray().GetArray());
        }

        [TestMethod]
        public void TestStack()
        {
            var stack = new MyStack();

            stack.Push(1);

            Assert.AreEqual(stack.GetArray().GetLength(), 1);

            stack.Pop();

            Assert.AreEqual(stack.GetArray().GetLength(), 0);

            Assert.IsTrue(stack.IsEmpty());
        }

        [TestMethod]
        public void TestPushStack()
        {
            var stack1 = new MyStack();
            var stack2 = new MyStack();

            stack1.Push(1);
            stack2.Push(2);

            CollectionAssert.AreNotEquivalent(stack1.GetArray().GetArray(), stack2.GetArray().GetArray());
        }
    }
}
