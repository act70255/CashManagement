﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class td_brokerpay
    {
        public string fund_no { get; set; }
        public string bank_no { get; set; }
        public string branch_no { get; set; }
        public DateTime tran_date { get; set; }
        public string pay_type { get; set; }
        public string pay_account { get; set; }
        public decimal? pay_net { get; set; }
        public string pay_title { get; set; }
    }
}