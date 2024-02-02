using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZieDitApp.MVVM.Models.ApiModels
{
    public class Date
    {
        public object iso { get; set; }
        public Datetime datetime { get; set; }
        public Timezone timezone { get; set; }
    }
}
