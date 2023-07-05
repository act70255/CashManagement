﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class fn_divid_p
    {
        public string fund_no { get; set; }
        public string fn_no { get; set; }
        /// <summary>
        /// 除息日期
        /// </summary>
        public DateTime ex_date { get; set; }
        /// <summary>
        /// 當日持有數
        /// </summary>
        public decimal hold_share { get; set; }
        public decimal div_rate { get; set; }
        /// <summary>
        /// 配息金額(除息金額)
        /// </summary>
        public decimal total_amt { get; set; }
        /// <summary>
        /// 所得稅率
        /// </summary>
        public float tax_rate { get; set; }
        /// <summary>
        /// 所得稅額
        /// </summary>
        public decimal tax_amt { get; set; }
        /// <summary>
        /// 應收淨額(除息淨額)
        /// </summary>
        public decimal net_amt { get; set; }
        /// <summary>
        /// 領息日
        /// </summary>
        public DateTime? recv_date { get; set; }
        /// <summary>
        /// 交易別
        /// </summary>
        public string action { get; set; }
        public decimal? rec_amt { get; set; }
        /// <summary>
        /// 交易編號
        /// </summary>
        public string recno { get; set; }
        /// <summary>
        /// 銀行代號
        /// </summary>
        public string bank_code { get; set; }
        /// <summary>
        /// 銀行帳號
        /// </summary>
        public string bank_account { get; set; }
        /// <summary>
        /// 集保帳號
        /// </summary>
        public string broker_account { get; set; }
        /// <summary>
        /// 郵費匯費
        /// </summary>
        public decimal? fee_amt { get; set; }
        /// <summary>
        /// 領取方式
        /// </summary>
        public string recv_kind { get; set; }
        /// <summary>
        /// 支票號碼
        /// </summary>
        public string check_no { get; set; }
        /// <summary>
        /// 溢配金額
        /// </summary>
        public decimal? over_dividend { get; set; }
        /// <summary>
        /// 畸零股款
        /// </summary>
        public decimal? turn_cash { get; set; }
        /// <summary>
        /// 溢配退還方式
        /// </summary>
        public string recv_kind2 { get; set; }
        /// <summary>
        /// 溢配退還帳號
        /// </summary>
        public string bank_account2 { get; set; }
        /// <summary>
        /// 溢配退還支票號碼
        /// </summary>
        public string check_no2 { get; set; }
        public string acccate { get; set; }
        public string p_code { get; set; }
        public int? checked1 { get; set; }
        public string check1_id { get; set; }
        public string check1_datetime { get; set; }
        public int? checked2 { get; set; }
        public string check2_id { get; set; }
        public string check2_datetime { get; set; }
    }
}