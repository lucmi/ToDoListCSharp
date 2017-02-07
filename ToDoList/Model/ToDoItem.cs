using System;

namespace ToDoList.Model
{
    class ToDoItem
    {
        private DateTime? _dueDate;
        private string _name;
        private DateTime? _dateCompleted;
        private DateTime _dateCreated;

        public DateTime? DueDate
        {
            get { return _dueDate; }
            set { _dueDate = value; }
        }

        public string Name
        {
            get { return Name; }
            set { _name = value; }
        }

        public bool Complete
        {
            get
            {
                return _dateCompleted != null;
            }

            set
            {
                if(value)
                {
                    _dateCompleted = DateTime.Now;
                }
                else
                {
                    _dateCompleted = null;
                }
            }
        }

        public ToDoItem(string name)
        {
            _dateCreated = DateTime.Now;
            Name = name;
        }

        public ToDoItem(string name, DateTime dueDate)
        {
            _dateCreated = DateTime.Now;
            Name = name;
            DueDate = dueDate;
        }
    }
}
