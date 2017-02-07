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
        public void TestMainViewModeInit()
        {
            var dataservice = new ToDoList.Model.ToDoListTestDataService();
            var main = new ToDoList.ViewModel.MainViewModel(dataservice);
            Assert.IsNotNull(main);
        }

        [TestMethod]
        public void TestMainViewModelListsExists()
        {
            var dataservice = new ToDoList.Model.ToDoListTestDataService();
            var main = new ToDoList.ViewModel.MainViewModel(dataservice);
            Assert.IsInstanceOfType(main.ToDoLists, typeof(ObservableCollection<ToDoList.Model.ToDoList>));
        }
    }
}
