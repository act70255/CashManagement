﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class sk_inv_odd
    {
        /// <summary>
        /// 帳戶別
        /// </summary>
        public string fund_no { get; set; }
        /// <summary>
        /// 股票代號
        /// </summary>
        public string sk_code { get; set; }
        /// <summary>
        /// 券商代號
        /// </summary>
        public string broker_code { get; set; }
        /// <summary>
        /// 流水序號
        /// </summary>
        public int seq_no { get; set; }
        /// <summary>
        /// 零股股數
        /// </summary>
        public decimal volumn { get; set; }
    }
}