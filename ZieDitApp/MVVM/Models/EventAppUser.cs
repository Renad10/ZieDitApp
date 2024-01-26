using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZieDitApp.Abstractions;

namespace ZieDitApp.MVVM.Models
{
    public class EventAppUser: TableData
    {
        [ForeignKey(typeof(Event))]
        public int EventId { get; set; }

        [ForeignKey(typeof(AppUser))]
        public int AppUserId { get; set; }

    }
}
