﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RenovationCalculation.Model
{
    public class TypeOfWorkModel
    {
        public int ID { get; set; }
        public string TypeOfWorkName { get; set; }
        public int QuantityHoursOfWork { get; set; }
        public int TotalPriceOfWork { get; set; }
    }
}
