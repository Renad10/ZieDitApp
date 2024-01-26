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
    public class LinkEmpToEventViewModel: INotifyPropertyChanged
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

        private List<AppUser> _employees;
        public List<AppUser> Employees
        {
            get { return _employees; }
            set
            {
                if (_employees != value)
                {
                    _employees = value;
                    OnPropertyChanged(nameof(Employees));
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

        private AppUser _selectedEmployee;
        public AppUser SelectedEmployee
        {
            get { return _selectedEmployee; }
            set
            {
                if (_selectedEmployee != value)
                {
                    _selectedEmployee = value;
                    OnPropertyChanged(nameof(SelectedEmployee));
                }
            }
        }

        public ICommand LinkEmpToEventCommand { get; set; }
        public LinkEmpToEventViewModel()
        {
            GetAllEvents();
            GetAllEmployees();
            LinkEmpToEventCommand = new Command(async () =>
            {
                SelectedEmployee.events.Add(SelectedEvent);
                SelectedEvent.appUsers.Add(SelectedEmployee);

                App.AppUserRepo.UpdateEntityWithChildren(SelectedEmployee);
                App.EventRepo.UpdateEntityWithChildren(SelectedEvent);

            });
        }
        private void GetAllEvents()
        {
            Events = App.EventRepo.GetEntitiesWithChildren();
        }

        private void GetAllEmployees()
        {
            Employees = App.AppUserRepo.GetEntitiesWithChildren().Where(e => e.role == "employee").ToList();
        }


        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

