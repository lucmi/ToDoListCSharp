using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using ToDoList.Model;

namespace ToDoList.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly IToDoListDataService _dataService;
        private ObservableCollection<Model.ToDoList> _toDoLists;
        private RelayCommand _newList;

        //TODO: Add commands in here for the menu items to bind to (Add new Item, add new List and exit)
        public RelayCommand NewList
        {
            get
            {
                return _newList ?? (_newList = new RelayCommand(() => CreateNewList()));
            }
        }

        public ObservableCollection<Model.ToDoList> ToDoLists
        {
            get { return _toDoLists; }
            set
            {
                Set(ref _toDoLists, value);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IToDoListDataService dataService)
        {
            _dataService = dataService;
            _dataService.GetToDoLists(
                (item, error) =>
                {
                    if(error != null)
                    {
                        //TODO: do something here about errors
                        return;
                    }
                    ToDoLists = item;
                }
            );
        }

        private void CreateNewList()
        {
            ToDoLists.Add(new Model.ToDoList("New List"));
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}