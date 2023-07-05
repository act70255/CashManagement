﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class lk_list
    {
        /// <summary>
        /// 基金代號
        /// </summary>
        public string fund_no { get; set; }
        /// <summary>
        /// 交易編號
        /// </summary>
        public string tran_no { get; set; }
        /// <summary>
        /// 券商編號
        /// </summary>
        public string broker_code { get; set; }
        /// <summary>
        /// 股票代號
        /// </summary>
        public string sk_code { get; set; }
        public int secno { get; set; }
        /// <summary>
        /// 原定還券日 
        /// </summary>
        public DateTime end_date { get; set; }
        /// <summary>
        /// 當天歸還股數
        /// </summary>
        public decimal det_volumn { get; set; }
        /// <summary>
        /// 成交費率
        /// </summary>
        public decimal? det_rate { get; set; }
        /// <summary>
        /// 實際天數
        /// </summary>
        public decimal? det_day { get; set; }
        /// <summary>
        /// 出借收入
        /// </summary>
        public decimal? det_interest { get; set; }
        /// <summary>
        /// 還券狀態
        /// </summary>
        public string action { get; set; }
        /// <summary>
        /// 實際還券日
        /// </summary>
        public DateTime? tran_date { get; set; }
        public decimal? det_cover { get; set; }
        public decimal? det_poundage { get; set; }
        public decimal? det_tax { get; set; }
        public string rec_tranno { get; set; }
        public string bank_code { get; set; }
        public string account { get; set; }
        public string address { get; set; }
        /// <summary>
        /// 還券成本2006/1026
        /// </summary>
        public decimal? det_net { get; set; }
        public DateTime? beg_date { get; set; }
        public string action_type { get; set; }
        public string p_code { get; set; }
    }
}