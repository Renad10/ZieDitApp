using CommunityToolkit.Maui.Core.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ZieDitApp.MVVM.Models;

namespace ZieDitApp.MVVM.ViewModels
{
    class RegisterToEventViewModel : INotifyPropertyChanged
    {
        private Event _event;
        public Event Event
        {
            get { return _event; }
            set
            {
                if (_event != value)
                {
                    _event = value;
                    OnPropertyChanged(nameof(Event));
                }
            }
        }

        private AppUser _appUser;
        public AppUser CurrentUser
        {
            get { return _appUser; }
            set
            {
                if (_appUser != value)
                {
                    _appUser = value;
                    OnPropertyChanged(nameof(CurrentUser));
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

        private string _accesBarcode;
        public string AccesBarCode
        {
            get { return _accesBarcode; }
            set
            {
                if (_accesBarcode != value)
                {
                    _accesBarcode = value;
                    OnPropertyChanged(nameof(AccesBarCode));
                }
            }
        }

        public ICommand RegisterGuestForEvent { get; set; }
        public RegisterToEventViewModel()
        {
            CurrentUser = App.AppUserRepo.GetEntitiesWithChildren().FirstOrDefault(a => a.Id == App.CurrentUserId);
            
            
            RegisterGuestForEvent = new Command(async () =>
            {
                CurrentUser.events.Add(Event);
                Event.appUsers.Add(CurrentUser);

                
                App.AppUserRepo.UpdateEntityWithChildren(CurrentUser);
                App.EventRepo.UpdateEntityWithChildren(Event);
            });
        }

        public void SetAccesCode()
        {
            AccesBarCode = string.Format("{0}-{1}", CurrentUser.Id, Event.Id);
        }
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
