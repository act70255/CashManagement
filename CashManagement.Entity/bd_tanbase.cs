﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class bd_tanbase
    {
        public string fund_no { get; set; }
        public string deal_no { get; set; }
        public string bond_no { get; set; }
        public DateTime tran_date { get; set; }
        public decimal interest { get; set; }
        public decimal real_interest { get; set; }
        public decimal tan_amt { get; set; }
        public decimal net2 { get; set; }
        public decimal day { get; set; }
        public DateTime buy_date { get; set; }
        public decimal net { get; set; }
        public decimal? par_value { get; set; }
        public DateTime? beg_date { get; set; }
        public decimal? real_rate { get; set; }
    }
}