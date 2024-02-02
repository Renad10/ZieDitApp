using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZieDitApp.MVVM.Models;

namespace ZieDitApp.MVVM.ViewModels
{
    internal class GuestInformationViewModel: INotifyPropertyChanged
    {
        private string _scannedBarcode;
        public string ScannedBarcode
        {
            get { return _scannedBarcode; }
            set
            {
                if (_scannedBarcode != value)
                {
                    _scannedBarcode = value;
                    OnPropertyChanged(nameof(ScannedBarcode));
                }
            }
        }

        private AppUser _guest;
        public AppUser Guest
        {
            get { return _guest; }
            set
            {
                if (_guest != value)
                {
                    _guest = value;
                    OnPropertyChanged(nameof(Guest));
                }
            }
        }

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


        public GuestInformationViewModel()
        {

        }

        public void GetEventAndGuest()
        {
            if (!string.IsNullOrWhiteSpace(ScannedBarcode))
            {
                string[] parts = ScannedBarcode.Split('-');


                if (parts.Length == 2)
                {
                    int guestId = int.Parse(parts[0]);
                    int eventId = int.Parse(parts[1]);

                    Event = App.EventRepo.GetEntity(eventId);
                    Guest = App.AppUserRepo.GetEntity(guestId);

                }
                else
                {
                    
                    Console.WriteLine("Ongeldige barcode-indeling.");
                }
            }

        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
