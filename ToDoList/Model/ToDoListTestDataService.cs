using System;
using System.Collections.ObjectModel;


namespace ToDoList.Model
{
    public class ToDoListTestDataService : IToDoListDataService
    {

        public void GetToDoLists(Action<ObservableCollection<ToDoList>, Exception> callback)
        {
            ObservableCollection<ToDoList> lists = new ObservableCollection<ToDoList>();
            ToDoList list = new ToDoList("Test List");
            list.Items.Add(new ToDoItem(name: "Test One",dueDate: DateTime.Now));
            lists.Add(list);
            callback(lists, null);
        }
    }
}
