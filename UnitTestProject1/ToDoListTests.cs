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

        [TestMethod]
        public void TestToDoListCreateItemCommand()
        {
            var list = new ToDoList.Model.ToDoList("Test List");
            Assert.AreEqual(0, list.Items.Count); //there should be no items in this list
            list.NewItem.Execute(null);
            Assert.AreEqual(1, list.Items.Count); //check that there is now 1 item in this list
        }

    }
}
