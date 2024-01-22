﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZieDitApp.Abstractions;

namespace ZieDitApp.MVVM.Models
{
    public class AppUser: TableData
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string role { get; set; }
    }
}
