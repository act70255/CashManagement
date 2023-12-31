﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class sk_tranerr
    {
        /// <summary>
        /// 交易編號
        /// </summary>
        public string tran_no { get; set; }
        /// <summary>
        /// 帳戶別
        /// </summary>
        public string fund_no { get; set; }
        /// <summary>
        /// 交易日期
        /// </summary>
        public DateTime tran_date { get; set; }
        /// <summary>
        /// 股票代號
        /// </summary>
        public string sk_code { get; set; }
        public string acccate { get; set; }
        /// <summary>
        /// 長短投
        /// </summary>
        public string term { get; set; }
        public string sk_type { get; set; }
        /// <summary>
        /// 分組別
        /// </summary>
        public string group_code { get; set; }
        /// <summary>
        /// 券商代號
        /// </summary>
        public string broker_code { get; set; }
        public string broker_type { get; set; }
        /// <summary>
        /// 參考編號
        /// </summary>
        public string ref_no { get; set; }
        /// <summary>
        /// 股數
        /// </summary>
        public decimal? volumn { get; set; }
        /// <summary>
        /// 價格
        /// </summary>
        public decimal? price { get; set; }
        /// <summary>
        /// 今交金額
        /// </summary>
        public decimal? total_amt { get; set; }
        /// <summary>
        /// 券商手續費
        /// </summary>
        public decimal? broker_comm { get; set; }
        /// <summary>
        /// 證交稅
        /// </summary>
        public decimal? trans_tax { get; set; }
        /// <summary>
        /// 交易淨額
        /// </summary>
        public decimal? net { get; set; }
        public decimal? d_volumn { get; set; }
        /// <summary>
        /// 交易成本
        /// </summary>
        public decimal? fund_cost { get; set; }
        /// <summary>
        /// 交易別
        /// </summary>
        public string action { get; set; }
        /// <summary>
        /// 交易狀態
        /// </summary>
        public string rec_status { get; set; }
        /// <summary>
        /// 參考券商
        /// </summary>
        public string broker_ref { get; set; }
        public decimal? real_rate { get; set; }
        public float? insurance_rate { get; set; }
        public float? pricea { get; set; }
        public string tran_out { get; set; }
        /// <summary>
        /// 分組成本
        /// </summary>
        public decimal? group_cost { get; set; }
        /// <summary>
        /// 交割日
        /// </summary>
        public DateTime? settle_date { get; set; }
        public decimal lcm_amt { get; set; }
        public decimal? co_cost { get; set; }
        /// <summary>
        /// 錯帳日期
        /// </summary>
        public DateTime? adj_date { get; set; }
        public int? adj_times { get; set; }
    }
}