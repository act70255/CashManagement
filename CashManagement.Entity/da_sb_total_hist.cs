﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class da_sb_total_hist
    {
        public string sys_no { get; set; }
        public string fund_no { get; set; }
        public string contract_no { get; set; }
        public DateTime tran_date { get; set; }
        public string app_no { get; set; }
        public DateTime beg_date { get; set; }
        public DateTime end_date { get; set; }
        public short buy_days { get; set; }
        public string broker_code { get; set; }
        public string bill_type { get; set; }
        public decimal par_value { get; set; }
        public decimal buy_price { get; set; }
        public decimal buy_rate { get; set; }
        public decimal buy_int { get; set; }
        public decimal buy_tax { get; set; }
        public decimal sold_price { get; set; }
        public string bill_no { get; set; }
        public int? buy_cut { get; set; }
        public int? relation { get; set; }
        public short? buymonth { get; set; }
        public short? buydate { get; set; }
        public string acccate { get; set; }
        public decimal accu_int { get; set; }
        public decimal accu_tax { get; set; }
        public decimal accu_days { get; set; }
    }
}