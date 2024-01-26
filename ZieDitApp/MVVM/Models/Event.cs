using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZieDitApp.Abstractions;

namespace ZieDitApp.MVVM.Models
{
    public class Event: TableData
    {
        public string name { get; set; }
        public DateTime date { get; set; }
        public string description { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public int maxCapacity { get; set; }
        public int registeredParticipants { get; set; }
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Activity>? activities { get; set; }

        [ManyToMany(typeof(EventAppUser))]
        public List<AppUser>? appUsers { get; set; }
    }
}
