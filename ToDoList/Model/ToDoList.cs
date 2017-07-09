using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;

namespace ToDoList.Model
{
    public class ToDoList
    {
        private string _name;
        private DateTime _created;
        private ObservableCollection<ToDoItem> _items;
        private RelayCommand _newItem;

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
            get
            {
                if (_items == null)
                {
                    _items = new ObservableCollection<ToDoItem>();
                }
                return _items;
            }
        }

        public ToDoList(string name)
        {
            Name = name;
            _created = DateTime.Now;
        }

        public RelayCommand NewItem
        {
            get
            {
                return _newItem ?? (_newItem = new RelayCommand(() => CreateNewItem()));
            }
        }

        private void CreateNewItem()
        {
            Items.Add(new ToDoItem("New Item"));
        }
    }
}
