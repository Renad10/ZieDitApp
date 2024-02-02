using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZieDitApp.MVVM.Models.ApiModels
{
    public class Holiday
    {
        public string name { get; set; }
        public string description { get; set; }
        public Country country { get; set; }
        public Date date { get; set; }
        public IList<string> type { get; set; }
        public string primary_type { get; set; }
        public string canonical_url { get; set; }
        public string urlid { get; set; }
        public string locations { get; set; }
        public string states { get; set; }

    }
}
