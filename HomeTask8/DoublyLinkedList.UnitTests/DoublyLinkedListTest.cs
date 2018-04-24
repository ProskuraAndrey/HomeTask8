using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeTask8;

namespace DoublyLinkedList.UnitTests
{
    [TestClass]
    public class DoublyLinkedListTest
    {
        [TestMethod]
        public void Add_NewUnitAddToTail_NewLinkedListWithUnit()
        {
            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            dll.Add(5);
            dll.Add(3);
            dll.Add(2);
            Assert.AreEqual(3, dll.Count);
        }

        [TestMethod]
        public void Add_NewUnitAddToHead_NewLinkedListWithUnit()
        {
            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            dll.Add(5);

            dll.AddFirst(10);

            DoublyLinkedList<int> dll2 = new DoublyLinkedList<int>();
            dll2.Add(5);
            dll2.Add(10);

            Assert.IsFalse(dll.Equals(dll2));
        }

        [TestMethod]
        public void Remove_DeleteUnitFromList_NewListWithoutUnit()
        {
            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            dll.Add(5);
            dll.Add(10);
            dll.Add(2);

            DoublyLinkedList<int> dll2 = new DoublyLinkedList<int>();
            dll2.Add(5);
            dll2.Add(2);

            dll.Remove(10);

            Assert.IsFalse(dll.Equals(dll2));
        }

        [TestMethod]
        public void Contains_SearchFiveInList_TrueReturned()
        {
            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            dll.Add(5);
            dll.Add(10);
            dll.Add(2);

            Assert.IsTrue(dll.Contains(5));
        }

        [TestMethod]
        public void Clear_DeleteUnitsFromList_EmptyLinkedList()
        {
            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            dll.Add(5);
            dll.Add(10);
            dll.Add(2);

            dll.Clear();
            Assert.IsTrue(dll.IsEmpty);
        }
    }
}
