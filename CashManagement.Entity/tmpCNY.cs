﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class tmpCNY
    {
        public string fund_no { get; set; }
        public string account { get; set; }
        public string security_id { get; set; }
        public string attitude { get; set; }
        public string acccate { get; set; }
        public string fx_type { get; set; }
        public string bond_kind { get; set; }
        public DateTime? tran_date { get; set; }
        public decimal? shares_units { get; set; }
        public string curr_code { get; set; }
        public decimal? shares_units_total { get; set; }
        public decimal? fund_cost_local { get; set; }
        public decimal? fund_cost_base { get; set; }
        public decimal? fund_cost_ntd { get; set; }
        public decimal? different_amt { get; set; }
        public decimal? fund_cost_local_total { get; set; }
        public decimal? fund_cost_base_total { get; set; }
        public decimal? fund_cost_ntd_total { get; set; }
        public decimal? market_value_local { get; set; }
        public decimal? market_value_base { get; set; }
        public decimal? market_value_ntd { get; set; }
        public decimal? net_accrued_income_local { get; set; }
        public decimal? net_accrued_income_base { get; set; }
        public decimal? net_accrued_income_ntd { get; set; }
        public decimal? int_local { get; set; }
        public decimal? int_base { get; set; }
        public decimal? int_ntd { get; set; }
        public string base_curr { get; set; }
        public string accrued_income_curr_code { get; set; }
        public decimal? market_value_cost { get; set; }
    }
}