using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Model;

namespace UnitTests
{
    [TestClass]
    public class ToDoListTests
    {
        [TestMethod]
        public void TestToDoListCreate()
        {
            try
            {
                var list = new ToDoList.Model.ToDoList("Test List");
                Assert.AreEqual("Test List", list.Name);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestToDoListAddItem()
        {
            var list = new ToDoList.Model.ToDoList("Test List");
            var item = new ToDoItem("Test Item");
            list.Items.Add(item);
            Assert.AreEqual(item, list.Items[0]);
        }

        [TestMethod]
        public void TestToDoListDateCreated()
        {
            var list = new ToDoList.Model.ToDoList("Test List");
            Assert.IsNotNull(list.Created);
            Assert.AreEqual(DateTime.Now, list.Created);
        }
    }
}
