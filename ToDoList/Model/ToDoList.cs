using System;
using System.Collections.ObjectModel;

namespace ToDoList.Model
{
    class ToDoList
    {
        private string _name;
        private DateTime _created;
        private ObservableCollection<ToDoItem> _items;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime Created
        {
            get { return _created; }
        }

        public ObservableCollection<ToDoItem> Items
        {
            set { _items = value; }
            get
            {
                if (_items == null)
                {
                    _items = new ObservableCollection<ToDoItem>();
                }
                return _items;
            }
        }
    }
}
