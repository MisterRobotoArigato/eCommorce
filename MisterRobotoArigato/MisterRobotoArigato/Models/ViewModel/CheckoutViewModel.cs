﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MisterRobotoArigato.Models.ViewModel
{
    public class CheckoutViewModel
    {
        public Basket Basket { get; set; }
        public decimal DiscountPercent { get; set; }
        public string DiscountName { get; set; }
        public Address Address { get; set; }
        public string Shipping { get; set; }

        public CheckoutViewModel()
        {
            Address = new Address();
        }
    }
}
