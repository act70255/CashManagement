﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class Audit_sk_price
    {
        public string sk_code { get; set; }
        public decimal price { get; set; }
        public decimal nav { get; set; }
        public DateTime tran_date { get; set; }
        public decimal updown { get; set; }
        public decimal high { get; set; }
        public decimal low { get; set; }
    }
}