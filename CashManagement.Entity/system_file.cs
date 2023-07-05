﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class system_file
    {
        /// <summary>
        /// 基金代號
        /// </summary>
        public string recno { get; set; }
        /// <summary>
        /// 系統代號
        /// </summary>
        public string sys_name { get; set; }
        /// <summary>
        /// 系統目前作帳時程
        /// </summary>
        public string sys_char { get; set; }
        /// <summary>
        /// 系統上一營業日
        /// </summary>
        public DateTime last_date { get; set; }
        /// <summary>
        /// 系統目前作帳日期
        /// </summary>
        public DateTime sys_date { get; set; }
        /// <summary>
        /// 系統下一營業日
        /// </summary>
        public DateTime next_date { get; set; }
        /// <summary>
        /// 系統下二營業日
        /// </summary>
        public DateTime af_next_date { get; set; }
        public int prtserial { get; set; }
    }
}