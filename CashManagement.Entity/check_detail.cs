﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class check_detail
    {
        public string bank_acct { get; set; }
        public string check_no { get; set; }
        public DateTime add_date { get; set; }
        public DateTime? acct_date { get; set; }
        public decimal? recno { get; set; }
        public DateTime? check_date { get; set; }
        public string title { get; set; }
        public decimal? amt { get; set; }
        public string check_memo { get; set; }
        public string user_id { get; set; }
        public bool? canceled { get; set; }
        public DateTime? pay_date { get; set; }
        public DateTime? change_date { get; set; }
        public string change_memo { get; set; }
        public string vouno { get; set; }
        public string pay_memo { get; set; }
        public string new_check { get; set; }
        public DateTime? sys_date { get; set; }
        public string block { get; set; }
        public string dept_no { get; set; }
        public int share { get; set; }
        public string org_title { get; set; }
        public bool blankcheck_void { get; set; }
    }
}