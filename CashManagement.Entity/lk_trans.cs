﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class lk_trans
    {
        public string rec_status { get; set; }
        public string fund_no { get; set; }
        public string tran_no { get; set; }
        public string rec_tranno { get; set; }
        public string broker_code { get; set; }
        public string action_type { get; set; }
        public string sk_code { get; set; }
        public decimal volumn { get; set; }
        public DateTime beg_date { get; set; }
        public DateTime end_date { get; set; }
        public decimal rate { get; set; }
        public string acccate { get; set; }
        public decimal avg_cost { get; set; }
        public decimal fund_cost { get; set; }
        public string action { get; set; }
        public DateTime tran_date { get; set; }
        public string bank_code { get; set; }
        /// <summary>
        /// 利息收入
        /// </summary>
        public decimal? interest { get; set; }
        /// <summary>
        /// 服務費
        /// </summary>
        public decimal? cover { get; set; }
        /// <summary>
        /// 手續費
        /// </summary>
        public decimal? poundage { get; set; }
        /// <summary>
        /// 稅額
        /// </summary>
        public decimal? tax { get; set; }
        public string account { get; set; }
        public string address { get; set; }
        public string skno_in { get; set; }
        public string skno_out { get; set; }
        public string p_code { get; set; }
    }
}