﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class inv_fnd_bal
    {
        public string sys_name { get; set; }
        public string code { get; set; }
        public int pno { get; set; }
        public string fno { get; set; }
        public string cap_tp { get; set; }
        public DateTime date { get; set; }
        public decimal exchrate { get; set; }
        public decimal qty { get; set; }
        public decimal settle_qty { get; set; }
        public decimal unlist_amt_buy { get; set; }
        public decimal unlist_qty_buy { get; set; }
        public decimal unlist_amt_sell { get; set; }
        public decimal unlist_qty_sell { get; set; }
        public decimal unlist_other { get; set; }
        public decimal cust_qty { get; set; }
        public decimal cost { get; set; }
        public decimal acc_cost { get; set; }
        public decimal cls_nav { get; set; }
        public decimal market_value { get; set; }
        public decimal acc_market_value { get; set; }
        public decimal cost_diff { get; set; }
        public decimal acc_cost_diff { get; set; }
        public decimal acc_exch_diff { get; set; }
        public decimal eom_cost_diff { get; set; }
        public decimal acc_eom_cost_diff { get; set; }
        public decimal acc_eom_exch_diff { get; set; }
        public decimal write_down { get; set; }
        public decimal acc_write_down { get; set; }
        public decimal acc_write_down_exch { get; set; }
        public decimal xd_amt { get; set; }
        public decimal acc_xd_amt { get; set; }
        public decimal rl_cost_diff { get; set; }
        public decimal acc_rl_cost_diff { get; set; }
        public decimal acc_rl_exch_diff { get; set; }
        public decimal rebate_amt { get; set; }
        public decimal acc_rebate_amt { get; set; }
        public short data_tp { get; set; }
        public bool is_close { get; set; }
        public decimal fno_cost { get; set; }
        public decimal fno_acc_cost { get; set; }
        public string loguser { get; set; }
        public DateTime logtime { get; set; }
    }
}