﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class fx_transaction
    {
        public int serial { get; set; }
        /// <summary>
        /// 基金代號(fund_file.fund_no)
        /// </summary>
        public string fund_no { get; set; }
        /// <summary>
        /// 交易日期
        /// </summary>
        public DateTime? tran_date { get; set; }
        public string account_number { get; set; }
        public string account_name { get; set; }
        public DateTime? trade_date { get; set; }
        /// <summary>
        /// 結帳日
        /// </summary>
        public DateTime? settlement_date { get; set; }
        /// <summary>
        /// 有效的日期 
        /// </summary>
        public DateTime? effective_date { get; set; }
        /// <summary>
        /// 證券名稱
        /// </summary>
        public string security_description1 { get; set; }
        public string security_description2 { get; set; }
        public string security_id { get; set; }
        /// <summary>
        /// 原幣別
        /// </summary>
        public string currency_code { get; set; }
        public decimal? net_amount_local { get; set; }
        public decimal? exchange_rate { get; set; }
        public decimal? ntd_rate { get; set; }
        /// <summary>
        /// 數量/面額
        /// </summary>
        public decimal? shares_units { get; set; }
        public decimal? net_amount_base { get; set; }
        public string summary_transaction_type { get; set; }
        public string detail_transaction_type { get; set; }
        public string transaction_description1 { get; set; }
        public string transaction_description2 { get; set; }
        /// <summary>
        /// 單號
        /// </summary>
        public string tran_no { get; set; }
        public string transaction_id { get; set; }
        public string security_type { get; set; }
    }
}