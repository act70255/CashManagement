﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class user_prog_log
    {
        /// <summary>
        /// 使用者帳號(emp_base.sales_id)
        /// </summary>
        public string id_no { get; set; }
        /// <summary>
        /// 系統編號(sys_base.sys_no)
        /// </summary>
        public string sys_no { get; set; }
        /// <summary>
        /// 程式編號(prog_base.prog_no)
        /// </summary>
        public string prog_no { get; set; }
        /// <summary>
        /// 登入日期
        /// </summary>
        public DateTime login_date { get; set; }
        /// <summary>
        /// 登入時間
        /// </summary>
        public string login_time { get; set; }
    }
}