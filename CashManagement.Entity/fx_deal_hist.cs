﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class fx_deal_hist
    {
        public string tran_no { get; set; }
        public string fund_no { get; set; }
        public string account { get; set; }
        public string security_id { get; set; }
        public string attitude { get; set; }
        public string acccate { get; set; }
        public string fx_type { get; set; }
        public string bond_kind { get; set; }
        public string detail_transaction_type { get; set; }
        public string action { get; set; }
        public DateTime? tran_date { get; set; }
        public DateTime? trade_date { get; set; }
        public DateTime? settlement_date { get; set; }
        public DateTime? effective_date { get; set; }
        public decimal? shares_units { get; set; }
        public string curr_code { get; set; }
        public decimal? amount_local { get; set; }
        public decimal? net_local { get; set; }
        public decimal? ex_rate { get; set; }
        public decimal? net_base { get; set; }
        public decimal? ntd_rate { get; set; }
        public decimal? net_ntd { get; set; }
        public decimal? fund_cost_local { get; set; }
        public decimal? fund_cost_base { get; set; }
        public decimal? fund_cost_ntd { get; set; }
        public decimal? fee_local { get; set; }
        public decimal? fee_base { get; set; }
        public decimal? fee_ntd { get; set; }
        public decimal? price_benefit_local { get; set; }
        public decimal? price_benefit_base { get; set; }
        public decimal? price_benefit_ntd { get; set; }
        public decimal? exrate_benefit_base { get; set; }
        public decimal? exrate_benefit_ntd { get; set; }
        public decimal? int_local { get; set; }
        public decimal? int_base { get; set; }
        public decimal? int_ntd { get; set; }
        public string ref_account { get; set; }
        public string security_type { get; set; }
        public decimal? fund_cost_local_count { get; set; }
        public decimal? fund_cost_base_count { get; set; }
        public decimal? fund_cost_ntd_count { get; set; }
        public string base_curr { get; set; }
        public string transaction_id { get; set; }
        public string bank_I_O { get; set; }
    }
}