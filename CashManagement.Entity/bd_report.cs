﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class bd_report
    {
        public DateTime? tran_date { get; set; }
        public string bond_kind_c { get; set; }
        public string action { get; set; }
        public string bond_no { get; set; }
        public string bond_alias { get; set; }
        public string broker_code { get; set; }
        public string broker_alias { get; set; }
        public decimal? par_value { get; set; }
        public string ccy_type { get; set; }
        public double? coupon_rate { get; set; }
        public decimal? unit_price { get; set; }
        public decimal yield { get; set; }
        public decimal? pay_amt { get; set; }
        public decimal? fund_gainloss { get; set; }
    }
}