﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class prog_base
    {
        /// <summary>
        /// 系統編號(sys_base.sys_no)
        /// </summary>
        public string sys_no { get; set; }
        /// <summary>
        /// 程式編號
        /// </summary>
        public string prog_no { get; set; }
        /// <summary>
        /// 程式名稱
        /// </summary>
        public string prog_name { get; set; }
        /// <summary>
        /// 程式中文描述
        /// </summary>
        public string prog_desc { get; set; }
        /// <summary>
        /// 程式按鍵順序
        /// </summary>
        public string sys_cmd { get; set; }
        /// <summary>
        /// 程式含新增功能
        /// </summary>
        public bool ins { get; set; }
        /// <summary>
        /// 程式含刪除功能
        /// </summary>
        public bool del { get; set; }
        /// <summary>
        /// 程式含修改功能
        /// </summary>
        public bool mdf { get; set; }
        /// <summary>
        /// 程式含查詢功能
        /// </summary>
        public bool qry { get; set; }
        /// <summary>
        /// 程式含報表功能
        /// </summary>
        public bool rpt { get; set; }
        public bool disabled { get; set; }
    }
}