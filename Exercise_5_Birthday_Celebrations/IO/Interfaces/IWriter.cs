﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations.IO.Interfaces
{
    public interface IWriter
    {
        public void Write(string text);
        public void WriteLine(string text);
    }
}
