﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class dafn_total
    {
        /// <summary>
        /// 帳冊別
        /// </summary>
        public string fund_no { get; set; }
        /// <summary>
        /// 投信公司代號
        /// </summary>
        public string fn_co { get; set; }
        /// <summary>
        /// 投信合約代碼
        /// </summary>
        public string contract_code { get; set; }
        /// <summary>
        /// 基金代號
        /// </summary>
        public string fn_no { get; set; }
        /// <summary>
        /// 公報別
        /// </summary>
        public string acccate { get; set; }
        /// <summary>
        /// 單位數
        /// </summary>
        public decimal tot_units { get; set; }
        /// <summary>
        /// 庫存成本,同fn_trans.fund_cost
        /// </summary>
        public decimal net { get; set; }
        /// <summary>
        /// 平均成本
        /// </summary>
        public decimal avg_cost { get; set; }
        /// <summary>
        /// 單位淨值
        /// </summary>
        public decimal unit_nav { get; set; }
        /// <summary>
        /// 市值
        /// </summary>
        public decimal market_price { get; set; }
        /// <summary>
        /// 年已實現收益
        /// </summary>
        public decimal year_gain { get; set; }
        /// <summary>
        /// 年已實現損失
        /// </summary>
        public decimal year_loss { get; set; }
        /// <summary>
        /// 月已實現收益
        /// </summary>
        public decimal month_gain { get; set; }
        /// <summary>
        /// 月已實現損失
        /// </summary>
        public decimal month_loss { get; set; }
        /// <summary>
        /// 日已實現收益
        /// </summary>
        public decimal day_gain { get; set; }
        /// <summary>
        /// 日已實現損益
        /// </summary>
        public decimal day_loss { get; set; }
        /// <summary>
        /// 日未實現收益
        /// </summary>
        public decimal day_ungain { get; set; }
        /// <summary>
        /// 日未實現損益
        /// </summary>
        public decimal day_unloss { get; set; }
        /// <summary>
        /// 今日異動單位數
        /// </summary>
        public decimal chg_units { get; set; }
        /// <summary>
        /// 今日異動成本
        /// </summary>
        public decimal chg_cost { get; set; }
        /// <summary>
        /// 庫存日期
        /// </summary>
        public DateTime tran_date { get; set; }
        /// <summary>
        /// 年除息數
        /// </summary>
        public decimal year_dividend { get; set; }
        /// <summary>
        /// 月除息數
        /// </summary>
        public decimal month_dividend { get; set; }
        /// <summary>
        /// 日除息數
        /// </summary>
        public decimal day_dividend { get; set; }
        public string p_code { get; set; }
    }
}