﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations.Models.Interfaces
{
    public interface IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
