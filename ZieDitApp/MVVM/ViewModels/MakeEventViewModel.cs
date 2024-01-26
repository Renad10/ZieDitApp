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
    class MakeEventViewModel: INotifyPropertyChanged
    {
        private string _eventName;
        public string EventName
        {
            get { return _eventName; }
            set
            {
                if (_eventName != value)
                {
                    _eventName = value;
                    OnPropertyChanged(nameof(EventName));
                }
            }
        }

        private string _eventDescription;
        public string EventDescription
        {
            get { return _eventDescription; }
            set
            {
                if (_eventDescription != value)
                {
                    _eventDescription = value;
                    OnPropertyChanged(nameof(EventDescription));
                }
            }
        }

        private DateTime _eventDate;
        public DateTime EventDate
        {
            get { return _eventDate; }
            set
            {
                if (_eventDate != value)
                {
                    _eventDate = value;
                    OnPropertyChanged(nameof(EventDate));
                }
            }
        }

        private string _eventStartTime;
        public string EventStartTime
        {
            get { return _eventStartTime; }
            set
            {
                if (_eventStartTime != value)
                {
                    _eventStartTime = value;
                    OnPropertyChanged(nameof(EventStartTime));
                }
            }
        }

        private string _eventEndTime;
        public string EventEndTime
        {
            get { return _eventEndTime; }
            set
            {
                if (_eventEndTime != value)
                {
                    _eventEndTime = value;
                    OnPropertyChanged(nameof(EventEndTime));
                }
            }
        }

        private int _eventMaxCapacity;
        public int EventMaxCapacity
        {
            get { return _eventMaxCapacity; }
            set
            {
                if (_eventMaxCapacity != value)
                {
                    _eventMaxCapacity = value;
                    OnPropertyChanged(nameof(EventMaxCapacity));
                }
            }
        }

        private string _activityName;
        public string ActivityName
        {
            get { return _activityName; }
            set
            {
                if (_activityName != value)
                {
                    _activityName = value;
                    OnPropertyChanged(nameof(ActivityName));
                }
            }
        }

        private string _activityDescription;
        public string ActivityDescription
        {
            get { return _activityDescription; }
            set
            {
                if (_activityDescription != value)
                {
                    _activityDescription = value;
                    OnPropertyChanged(nameof(ActivityDescription));
                }
            }
        }

        private string _activityStartTime;
        public string ActivityStartTime
        {
            get { return _activityStartTime; }
            set
            {
                if (_activityStartTime != value)
                {
                    _activityStartTime = value;
                    OnPropertyChanged(nameof(ActivityStartTime));
                }
            }
        }

        private string _activityEndTime;
        public string ActivityEndTime
        {
            get { return _activityEndTime; }
            set
            {
                if (_activityEndTime != value)
                {
                    _activityEndTime = value;
                    OnPropertyChanged(nameof(ActivityEndTime));
                }
            }
        }

        private List<Activity> _activites;
        public List<Activity> Activites
        {
            get { return _activites; }
            set
            {
                if (_activites != value)
                {
                    _activites = value;
                    OnPropertyChanged(nameof(Activites));
                }
            }
        }

        private int _addedActivitiesNumber;
        public int AddedActivitiesNumber
        {
            get { return _addedActivitiesNumber; }
            set
            {
                if (_addedActivitiesNumber != value)
                {
                    _addedActivitiesNumber = value;
                    OnPropertyChanged(nameof(AddedActivitiesNumber));
                }
            }
        }

        public ICommand AddEventCommand { get; set; }
        public ICommand AddActivityToEventCommand { get; set; }

        public MakeEventViewModel()
        {
            Activites = new List<Activity>();
            AddEventCommand = new Command(async () =>
            {
                var myEvent = new Event()
                {
                    name = EventName,
                    description = EventDescription,
                    startTime = EventStartTime,
                    endTime = EventEndTime, 
                    date= EventDate,
                    maxCapacity= EventMaxCapacity,

                    activities = Activites,
                };
                App.EventRepo.SaveEntityWithChildren(myEvent);
                


                Console.WriteLine(App.EventRepo.StatusMessage);

            });
            AddActivityToEventCommand = new Command(async () =>
            {
                if (ActivityName.Length > 0 && ActivityDescription.Length > 0)
                {
                    var myActivity = new Activity()
                    {
                        name = ActivityName,
                        description = ActivityDescription,
                        startTime = ActivityStartTime,
                        endTime = ActivityEndTime,
                    };
                    Activites.Add(myActivity);
                    AddedActivitiesNumber = Activites.Count;
                }
            });
        }
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
