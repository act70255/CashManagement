﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class ft_trandtl
    {
        public string broker_no { get; set; }
        public string account { get; set; }
        public DateTime tran_date { get; set; }
        public string tran_no { get; set; }
        public string tran_no_c { get; set; }
        public string bs_type { get; set; }
        public string ft_no { get; set; }
        public string ft_ym { get; set; }
        public decimal ex_value { get; set; }
        public string cp_type { get; set; }
        public DateTime? settle_date { get; set; }
        public decimal tran_price { get; set; }
        public decimal tran_lot { get; set; }
        public decimal pre_amt { get; set; }
        public decimal tran_fee { get; set; }
        public decimal tran_tax { get; set; }
        public string action { get; set; }
        public string fund_no { get; set; }
        public string purpose { get; set; }
        public DateTime org_tran_date { get; set; }
        public string org_tran_no { get; set; }
        public decimal org_tran_price { get; set; }
        public decimal org_pre_amt { get; set; }
        public string offset_type { get; set; }
    }
}