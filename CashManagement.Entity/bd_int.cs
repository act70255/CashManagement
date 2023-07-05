﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class bd_int
    {
        /// <summary>
        /// 債券編號
        /// </summary>
        public string bond_no { get; set; }
        /// <summary>
        /// 計息起日
        /// </summary>
        public DateTime beg_date { get; set; }
        /// <summary>
        /// 計息止日
        /// </summary>
        public DateTime end_date { get; set; }
        /// <summary>
        /// 計息利率
        /// </summary>
        public decimal int_rate { get; set; }
        /// <summary>
        /// 本期利息
        /// </summary>
        public decimal period_int { get; set; }
        /// <summary>
        /// 本期天數
        /// </summary>
        public int period_days { get; set; }
        public int base_days { get; set; }
        public int step { get; set; }
        public decimal base_cap { get; set; }
        public decimal base_int { get; set; }
        public decimal rec_int { get; set; }
        public decimal rec_cap { get; set; }
        public decimal rem_cap { get; set; }
        public DateTime? int_date { get; set; }
        public int? YearDays { get; set; }
        public DateTime? rec_date { get; set; }
    }
}