﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class op_brokerpay
    {
        public DateTime tran_date { get; set; }
        public string fund_no { get; set; }
        public string broker_co { get; set; }
        public string broker_code { get; set; }
        public string unified_no { get; set; }
        public string bill_name { get; set; }
        public string pay_type { get; set; }
        public string pay_account { get; set; }
        public decimal amt_in { get; set; }
        public decimal amt_out { get; set; }
        public decimal? pay_net { get; set; }
        public string pay_title { get; set; }
        public string dvp_fop { get; set; }
        public string memo { get; set; }
    }
}