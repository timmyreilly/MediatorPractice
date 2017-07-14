﻿using MediatatorPractice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatatorPractice
{
    public class JobChangedEventArgs : EventArgs
    {
        public Job Job { get; set; }
    }
}
