﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class tra_fx_deal_acc
    {
        public string trade_no { get; set; }
        public decimal exchrate { get; set; }
        public decimal exchrate_long { get; set; }
        public decimal exchrate_short { get; set; }
        public decimal exchrate_notional { get; set; }
        public decimal exchrate_inc_settle { get; set; }
        public decimal exchrate_cash { get; set; }
        public decimal acc_amt { get; set; }
        public decimal notional_amt_long { get; set; }
        public decimal acc_notional_amt_long { get; set; }
        public decimal notional_amt_short { get; set; }
        public decimal acc_notional_amt_short { get; set; }
        public string notional_ccy { get; set; }
        public string notional_bank { get; set; }
        public string notional_bank_accno { get; set; }
        public decimal notional_amt { get; set; }
        public decimal acc_notional_amt { get; set; }
        public decimal acc_inc_settle_amt { get; set; }
        public decimal cash_cost_amt { get; set; }
        public decimal cash_exch_diff { get; set; }
        public string inc_settle_bank { get; set; }
        public string inc_settle_bank_accno { get; set; }
        public decimal ex_notional_amt_long { get; set; }
        public decimal acc_ex_notional_amt_long { get; set; }
        public decimal ex_notional_amt_short { get; set; }
        public decimal acc_ex_notional_amt_short { get; set; }
        public decimal ex_notional_amt { get; set; }
        public decimal acc_ex_notional_amt { get; set; }
        public string ex_broker { get; set; }
        public string ex_bank_opp { get; set; }
        public string ex_bank_accno_opp { get; set; }
        public string loguser { get; set; }
        public DateTime logtime { get; set; }
    }
}