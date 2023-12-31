﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class bdrs_cal_hist
    {
        public string fund_no { get; set; }
        /// <summary>
        /// 季底日期
        /// </summary>
        public DateTime cal_date { get; set; }
        /// <summary>
        /// 交易編號
        /// </summary>
        public string deal_no { get; set; }
        /// <summary>
        /// 債券編號
        /// </summary>
        public string bond_no { get; set; }
        /// <summary>
        /// 交易金額
        /// </summary>
        public decimal? tran_price { get; set; }
        /// <summary>
        /// 交易面額
        /// </summary>
        public decimal? tran_value { get; set; }
        /// <summary>
        /// 交易利率
        /// </summary>
        public decimal? tran_rate { get; set; }
        /// <summary>
        /// 交易起始日
        /// </summary>
        public DateTime? tran_date { get; set; }
        /// <summary>
        /// 天期
        /// </summary>
        public int? tran_days { get; set; }
        /// <summary>
        /// 到期日期
        /// </summary>
        public DateTime? end_date { get; set; }
        /// <summary>
        /// 交易對手
        /// </summary>
        public string broker_code { get; set; }
        /// <summary>
        /// 利息費用
        /// </summary>
        public decimal? int_fee { get; set; }
        /// <summary>
        /// 到期償還金額
        /// </summary>
        public decimal? pay_price { get; set; }
        public decimal? cal_amt { get; set; }
        /// <summary>
        /// 季底年
        /// </summary>
        public int? cal_year { get; set; }
        /// <summary>
        /// 季底月
        /// </summary>
        public int? cal_month { get; set; }
        public int? cal_day { get; set; }
        public decimal? cal_next_amt { get; set; }
        public int? cal_next_day { get; set; }
    }
}