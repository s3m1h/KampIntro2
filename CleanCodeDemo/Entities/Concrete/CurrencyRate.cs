﻿using CleanCodeDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo.Entities.Concrete
{
    public class CurrencyRate:IEntity
    {
        public decimal Price { get; set; }
        public int Currency { get; set; }
    }
}
