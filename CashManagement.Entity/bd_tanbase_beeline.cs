﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class bd_tanbase_beeline
    {
        public string deal_no { get; set; }
        public string bond_no { get; set; }
        public DateTime buy_date { get; set; }
        public DateTime end_date { get; set; }
        public int day { get; set; }
        public decimal par_value { get; set; }
        public decimal tan_net { get; set; }
        public DateTime? real_end_date { get; set; }
    }
}