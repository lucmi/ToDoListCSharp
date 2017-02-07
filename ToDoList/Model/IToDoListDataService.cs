using System;
using System.Collections.ObjectModel;

namespace ToDoList.Model
{
    public interface IToDoListDataService
    {
        void GetToDoLists(Action<ObservableCollection<ToDoList>, Exception> callback);
    }
}
