﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class da_td_trans
    {
        public DateTime tran_date { get; set; }
        public short action { get; set; }
        public string fund_no { get; set; }
        public string contract_no { get; set; }
        public string deal_no { get; set; }
        public string bank_no { get; set; }
        public string branch_no { get; set; }
        public string deposit_type { get; set; }
        public DateTime beg_date { get; set; }
        public DateTime end_date { get; set; }
        public string period_type { get; set; }
        public string int_cont { get; set; }
        public string int_type { get; set; }
        public decimal capital { get; set; }
        public decimal int_rate { get; set; }
        public decimal? cancel_rate { get; set; }
        public decimal? cancel_int { get; set; }
        public decimal? cancel_tax { get; set; }
        public decimal? cancel_net { get; set; }
        public string acccate { get; set; }
    }
}