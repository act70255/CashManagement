﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class fx_derivatives_hist
    {
        public string tran_no { get; set; }
        public string account_seq { get; set; }
        public DateTime? tran_date { get; set; }
        public string account { get; set; }
        public DateTime? trade_date { get; set; }
        public DateTime? settlement_date { get; set; }
        public DateTime? effective_date { get; set; }
        public string type { get; set; }
        public string curr_code { get; set; }
        public string action { get; set; }
        public decimal? net_amount { get; set; }
        public decimal? net_amount_base { get; set; }
        public decimal? net_amount_ntd { get; set; }
    }
}