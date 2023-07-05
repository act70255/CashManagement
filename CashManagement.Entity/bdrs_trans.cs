﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class bdrs_trans
    {
        public byte rec_status { get; set; }
        public string fund_no { get; set; }
        public string bond_no { get; set; }
        public string deal_no { get; set; }
        public string broker_code { get; set; }
        public DateTime tran_date { get; set; }
        public decimal tran_price { get; set; }
        public decimal bond_value { get; set; }
        public decimal tran_rate { get; set; }
        public int tran_days { get; set; }
        public DateTime end_date { get; set; }
        public decimal int_fee { get; set; }
        public decimal? tax { get; set; }
        public decimal? pay_price { get; set; }
        public decimal? act_rate { get; set; }
        public int? act_days { get; set; }
        public DateTime? act_end_date { get; set; }
        public decimal? act_int_fee { get; set; }
        public decimal? act_tax { get; set; }
        public decimal? act_pay_price { get; set; }
        public string note { get; set; }
        public int? status { get; set; }
        public int? dtl_status { get; set; }
        public string no1 { get; set; }
        public string act_no1 { get; set; }
        public string new_dealno { get; set; }
    }
}