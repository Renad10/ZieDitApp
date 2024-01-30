using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ZieDitApp.MVVM.Models;

namespace ZieDitApp.MVVM.ViewModels
{
    public class AllEventsViewModel : INotifyPropertyChanged
    {
        private List<Event> _events;
        public List<Event> Events
        {
            get { return _events; }
            set
            {
                if (_events != value)
                {
                    _events = value;
                    OnPropertyChanged(nameof(Events));
                }
            }
        }

        private Event _selectedEvent;
        public Event SelectedEvent
        {
            get { return _selectedEvent; }
            set
            {
                if (_selectedEvent != value)
                {
                    _selectedEvent = value;
                    OnPropertyChanged(nameof(SelectedEvent));
                }
            }
        }
        public ICommand GoToView { get; set; }
        public AllEventsViewModel()
        {
            GetAllEvents();
            GoToView = new Command(async () =>
            {
                

            });
        }
        
        private void GetAllEvents()
        {
           Events = App.EventRepo.GetEntitiesWithChildren();
        }

        
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
