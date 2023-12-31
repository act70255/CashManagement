﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class sk_price
    {
        /// <summary>
        /// 股票代號
        /// </summary>
        public string sk_code { get; set; }
        /// <summary>
        /// 股票收盤價
        /// </summary>
        public decimal price { get; set; }
        /// <summary>
        /// 淨值
        /// </summary>
        public decimal nav { get; set; }
        /// <summary>
        /// 收盤價日期
        /// </summary>
        public DateTime tran_date { get; set; }
        /// <summary>
        /// 漲跌
        /// </summary>
        public decimal updown { get; set; }
        /// <summary>
        /// 最高價格
        /// </summary>
        public decimal high { get; set; }
        /// <summary>
        /// 最低價格
        /// </summary>
        public decimal low { get; set; }
    }
}