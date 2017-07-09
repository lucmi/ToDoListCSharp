using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;
using ToDoList;

namespace UnitTests
{
    [TestClass]
    public class MainViewModelTests
    {
        [TestMethod]
        public void TestMainViewModelCreateNewList()
        {
            var mainViewModel = new ToDoList.ViewModel.MainViewModel(new ToDoList.Model.ToDoListTestDataService());
            mainViewModel.NewList.Execute(null);
            Assert.AreEqual(2, mainViewModel.ToDoLists.Count); // should be 2 lists after the execute command
        }

    }
}
