﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class op_total_hist
    {
        public string fund_no { get; set; }
        public string app_no { get; set; }
        public DateTime tran_date { get; set; }
        public DateTime end_date { get; set; }
        public short tran_days { get; set; }
        public string bill_type { get; set; }
        public string acccate { get; set; }
        public string broker_co { get; set; }
        public string broker_code { get; set; }
        public decimal par_value { get; set; }
        public decimal bill_rate { get; set; }
        public short? bill_days { get; set; }
        public decimal bill_int { get; set; }
        public decimal? tran_amt { get; set; }
        public decimal? bef_tax { get; set; }
        public decimal tran_price { get; set; }
        public decimal fund_cost { get; set; }
        public decimal? tran_rate { get; set; }
        public decimal tran_revenue { get; set; }
        public decimal tran_tax { get; set; }
        public decimal sold_price { get; set; }
        public string bill_no { get; set; }
        public int? evaluation_days { get; set; }
        public string market { get; set; }
        public decimal market_rate { get; set; }
        public decimal market_price { get; set; }
        public int hold_days { get; set; }
        public decimal accrued_int { get; set; }
        public decimal unrelized_gass { get; set; }
        public decimal unrelized_loss { get; set; }
        public DateTime save_date { get; set; }
    }
}