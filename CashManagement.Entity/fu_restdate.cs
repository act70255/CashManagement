﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class fu_restdate
    {
        /// <summary>
        /// 月份
        /// </summary>
        public int month { get; set; }
        /// <summary>
        /// 放假日
        /// </summary>
        public DateTime restdate { get; set; }
        /// <summary>
        /// 是否作帳
        /// </summary>
        public string accounting { get; set; }
    }
}