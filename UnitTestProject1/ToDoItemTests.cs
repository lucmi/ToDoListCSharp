using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Model;

namespace UnitTests
{
    [TestClass]
    public class ToDoItemTests
    {
        [TestMethod]
        public void TestCreateNamedToDoItem()
        {
            var item = new ToDoItem(name: "Test Item");
            Assert.IsNotNull(item);
        }

        [TestMethod]
        public void TestCreateNamedDueDateToDoItem()
        {
            var item = new ToDoItem(name: "Test Item", dueDate: new DateTime(2017,1,1));
            Assert.IsNotNull(item);
        }

        [TestMethod]
        public void TestItemIsNamedCorrectly()
        {
            var item = new ToDoItem(name: "Test Item");
            Assert.AreEqual("Test Item", item.Name);
        }

        [TestMethod]
        public void TestItemComplete()
        {
            var item = new ToDoItem(name: "Test Item");
            Assert.IsFalse(item.Complete);
            item.Complete = true;
            Assert.IsTrue(item.Complete);
            item.Complete = false;
            Assert.IsFalse(item.Complete);
        }

        [TestMethod]
        public void TestItemDueDate()
        {
            var item = new ToDoItem(name: "Test Item");
            Assert.IsNull(item.DueDate);
            item.DueDate = new DateTime(2017, 01, 01);
            Assert.AreEqual("1/01/2017 12:00:00 a.m.", item.DueDate.ToString());
            item.DueDate = null;
            Assert.IsNull(item.DueDate);
        }
    }
}
