﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class skr055_total_hist
    {
        /// <summary>
        /// 帳戶別(fund_file.fund_no)
        /// </summary>
        public string fund_no { get; set; }
        /// <summary>
        /// 股票代號(sk_base.sk_code)
        /// </summary>
        public string sk_code { get; set; }
        /// <summary>
        /// 現存股數
        /// </summary>
        public decimal volumn { get; set; }
        /// <summary>
        /// 交易日期
        /// </summary>
        public DateTime tran_date { get; set; }
        public string acccate { get; set; }
        /// <summary>
        /// 庫存日期
        /// </summary>
        public DateTime stock_date { get; set; }
        public decimal? sell_volumn { get; set; }
    }
}