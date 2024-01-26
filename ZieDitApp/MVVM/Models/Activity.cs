using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZieDitApp.Abstractions;

namespace ZieDitApp.MVVM.Models
{
    public class Activity:TableData
    {
        public string name { get; set; }
        public string description { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        [ForeignKey(typeof(Event))]
        public int eventId { get; set; }    
        [ManyToOne(CascadeOperations = CascadeOperation.CascadeInsert)]
        public Event Event { get; set; }
    }
}
