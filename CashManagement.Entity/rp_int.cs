﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class rp_int
    {
        public string bond_no { get; set; }
        public DateTime beg_date { get; set; }
        public DateTime end_date { get; set; }
        public decimal int_rate { get; set; }
        public decimal period_int { get; set; }
        public int period_days { get; set; }
        public int base_days { get; set; }
        public int step { get; set; }
        public decimal base_cap { get; set; }
        public decimal base_int { get; set; }
        public decimal rec_int { get; set; }
        public decimal rec_cap { get; set; }
        public decimal rem_cap { get; set; }
        public string int_date { get; set; }
        public int? YearDays { get; set; }
        public DateTime? recv_date { get; set; }
    }
}