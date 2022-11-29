﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CaliburnMicroApp_Practice3.Models
{
    /// <summary>
    /// Represents a particular stat of a character
    /// </summary>
    public class StatModel
    {
        public string Name { get; set; }
        public int Val { get; set; }
        public Color Color { get; set; }    
    }
}
