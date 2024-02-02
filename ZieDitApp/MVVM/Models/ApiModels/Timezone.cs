using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZieDitApp.MVVM.Models.ApiModels
{
    public class Timezone
    {
        public string offset { get; set; }
        public string zoneabb { get; set; }
        public int zoneoffset { get; set; }
        public int zonedst { get; set; }
        public int zonetotaloffset { get; set; }

    }
}
