﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZieDitApp.MVVM.Models.ApiModels
{
    public class Datetime
    {
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public int? hour { get; set; }
        public int? minute { get; set; }
        public int? second { get; set; }
    }
}
