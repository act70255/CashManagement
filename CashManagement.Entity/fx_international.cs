﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class fx_international
    {
        public string fund_no { get; set; }
        public DateTime? tran_date { get; set; }
        public string broker { get; set; }
        /// <summary>
        /// 證券代號
        /// </summary>
        public string security_id { get; set; }
        /// <summary>
        /// 國外MBS帳戶
        /// </summary>
        public string account_number { get; set; }
        /// <summary>
        /// 數量/面額
        /// </summary>
        public decimal? shares_units { get; set; }
        /// <summary>
        /// 原幣交割金額
        /// </summary>
        public decimal? tot_amt { get; set; }
        public decimal? factor { get; set; }
        public decimal? ytm { get; set; }
        public decimal? coupon { get; set; }
        public decimal? collateral { get; set; }
        public decimal? psa { get; set; }
        public decimal? al { get; set; }
        public decimal? Price { get; set; }
        /// <summary>
        /// 交割日期
        /// </summary>
        public DateTime? settlement_date { get; set; }
        /// <summary>
        /// 交易日期
        /// </summary>
        public DateTime? trade_date { get; set; }
        /// <summary>
        /// 前手息
        /// </summary>
        public decimal? interest { get; set; }
        public string cusip { get; set; }
        public string data_kind { get; set; }
    }
}