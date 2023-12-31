﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class fx_int_file
    {
        /// <summary>
        /// 交易狀態
        /// </summary>
        public bool rec_status { get; set; }
        /// <summary>
        /// 基金代號
        /// </summary>
        public string fund_no { get; set; }
        /// <summary>
        /// 交易編號
        /// </summary>
        public string deal_no { get; set; }
        /// <summary>
        /// 交易種類(買入領息檔 deal_type=&apos;00&apos;  ;賣出領息檔  deal_type=&apos;01&apos;)
        /// </summary>
        public string deal_type { get; set; }
        /// <summary>
        /// 換息方式(01-每月換息 02-Quarterly 03-Semi-annually 04-每年換息05-期滿換息)
        /// </summary>
        public string fd_type { get; set; }
        /// <summary>
        /// 計期方式(code_file.item_type = &apos;FP&apos;)(01-Act/365  02-30/360  03-Act/360 04-Act/Act  )
        /// </summary>
        public string period_type { get; set; }
        /// <summary>
        /// 計息方式(浮動/固定)(code_file.item_type = &apos;t4&apos;) (1-固定利率 2 -浮動利率 )
        /// </summary>
        public string int_type { get; set; }
        /// <summary>
        /// 存入本金
        /// </summary>
        public decimal capital { get; set; }
        /// <summary>
        /// 買入利率
        /// </summary>
        public decimal int_rate { get; set; }
        /// <summary>
        /// 計息起日
        /// </summary>
        public DateTime beg_date { get; set; }
        /// <summary>
        /// 計息止日
        /// </summary>
        public DateTime end_date { get; set; }
        /// <summary>
        /// 預約領息日
        /// </summary>
        public DateTime int_date { get; set; }
        /// <summary>
        /// 計息天數
        /// </summary>
        public int actual_days { get; set; }
        /// <summary>
        /// 本期利息
        /// </summary>
        public decimal interest { get; set; }
        /// <summary>
        /// 本期稅額
        /// </summary>
        public decimal tax { get; set; }
        /// <summary>
        /// 本期利息淨額
        /// </summary>
        public decimal net { get; set; }
        /// <summary>
        /// 實際領息日期
        /// </summary>
        public DateTime? rec_date { get; set; }
        /// <summary>
        /// 實際領息金額
        /// </summary>
        public decimal? recv_int { get; set; }
        /// <summary>
        /// 實際領息稅額
        /// </summary>
        public decimal? recv_tax { get; set; }
        /// <summary>
        /// 實際領息淨額
        /// </summary>
        public decimal? recv_net { get; set; }
        /// <summary>
        /// 應計稅額
        /// </summary>
        public decimal? accrued_tax { get; set; }
        /// <summary>
        /// 課稅利率
        /// </summary>
        public decimal? int_rate2 { get; set; }
        public bool? chk_price { get; set; }
        public decimal? fx_rate { get; set; }
        public decimal? nt_amt { get; set; }
    }
}