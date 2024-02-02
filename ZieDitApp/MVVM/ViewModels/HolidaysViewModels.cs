using System.ComponentModel;
using System.Windows.Input;
using ZieDitApp.MVVM.Models.ApiModels;

namespace ZieDitApp.MVVM.ViewModels
{
    public class HolidaysViewModels : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private List<Holiday> _holidays;
        public List<Holiday> Holidays
        {
            get { return _holidays; }
            set
            {
                if (_holidays != value)
                {
                    _holidays = value;
                    OnPropertyChanged(nameof(Holidays));
                }
            }
        }

        
        private string _year;
        public string Year
        {
            get { return _year; }
            set
            {
                if (_year != value)
                {
                    _year = value;
                    OnPropertyChanged(nameof(Year));
                }
            }
        }

        public ICommand GetHolidaysCommand { get; set; }
        public HolidaysViewModels()
        {
            Holidays = new List<Holiday>(); 
            
            GetHolidaysCommand = new Command(async () =>
            {
                Holidays = await HolidayLogic.GetHolidays(Year);

            });
        }
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
