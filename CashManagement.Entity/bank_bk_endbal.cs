﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class bank_bk_endbal
    {
        public DateTime tran_date { get; set; }
        public string bank_acct { get; set; }
        public string bank_l_acct { get; set; }
        public DateTime? last_date { get; set; }
        public string ccy_type { get; set; }
        public decimal bk_dendbal { get; set; }
        public decimal dendbal { get; set; }
        public decimal rpt_temp_amt { get; set; }
        public int rec_status { get; set; }
        public string file_name { get; set; }
        public string op_name { get; set; }
    }
}