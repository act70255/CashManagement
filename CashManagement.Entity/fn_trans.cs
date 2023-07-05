﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class fn_trans
    {
        public string action { get; set; }
        public string deal_no { get; set; }
        public string fund_no { get; set; }
        public string p_code { get; set; }
        public string fn_co { get; set; }
        public string fn_no { get; set; }
        public string acccate { get; set; }
        public DateTime tran_date { get; set; }
        public decimal tot_amt { get; set; }
        public decimal tot_unit { get; set; }
        public decimal unit_nav { get; set; }
        public decimal broker_fee { get; set; }
        public decimal bank_fee { get; set; }
        public decimal net { get; set; }
        public decimal fund_cost { get; set; }
        public decimal p_cost { get; set; }
        public decimal co_cost { get; set; }
        public decimal trust_unit { get; set; }
        public decimal confirm_unit { get; set; }
        public decimal newconfirm_unit { get; set; }
        public short dtl_status { get; set; }
        public string broker_code { get; set; }
        public decimal lcm_amt { get; set; }
        public string memo { get; set; }
        public string back_dealno { get; set; }
        public DateTime? trade_date { get; set; }
        public DateTime? settle_date { get; set; }
        public DateTime? settledate_bill { get; set; }
        public string ipo_chk { get; set; }
        public string bank_account { get; set; }
        /// <summary>
        /// IPO(申)預付金額
        /// </summary>
        public decimal? ipo_amt { get; set; }
        public string ipo_deal_no { get; set; }
        public string Deal_Way { get; set; }
        public string Data_Source { get; set; }
        public string Data_Status { get; set; }
        public string Deal_Type { get; set; }
        public string Ets_Deal_No { get; set; }
        public string Lock_Id { get; set; }
        public DateTime? Lock_Date { get; set; }
        public string Lock_Id2 { get; set; }
        public DateTime? Lock_Date2 { get; set; }
        public string Manager_Id { get; set; }
        public string Trader_Id { get; set; }
        public string Approve_Id { get; set; }
        public DateTime? Approve_Date { get; set; }
        public DateTime? Reply_Date { get; set; }
        public DateTime? Decision_Date { get; set; }
        public DateTime? Decision_Deal_Date { get; set; }
        public DateTime? Nav_Date { get; set; }
        public string Is_PrePay { get; set; }
        public string PrePay_No { get; set; }
        public decimal? PrePay_Amt { get; set; }
        public decimal d_cost { get; set; }
        public decimal t_cost { get; set; }
        public decimal? tran_fee { get; set; }
        public decimal? tran_tax { get; set; }
        public decimal? commission { get; set; }
        public decimal? other_fee { get; set; }
        public decimal? exchange_fee { get; set; }
    }
}