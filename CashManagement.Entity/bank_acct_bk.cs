﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class bank_acct_bk
    {
        public string bank_no { get; set; }
        public string branch_no { get; set; }
        public string bank_acct { get; set; }
        public string act_type { get; set; }
        public string ccy_type { get; set; }
        public decimal min_amt { get; set; }
        public int seq_no { get; set; }
        public int fee_type1 { get; set; }
        public int fee_type2 { get; set; }
        public string bank_acct2 { get; set; }
        public string bank_acct_edi { get; set; }
        public string swift_code { get; set; }
        public int share_acct { get; set; }
        public int policy_acct { get; set; }
        public string acct_memo { get; set; }
        public string rec_int_type { get; set; }
        public int close_acct { get; set; }
        public DateTime? close_date { get; set; }
        public decimal acct_rate { get; set; }
        public string emp_id_1 { get; set; }
        public string emp_id_2 { get; set; }
        public int? tmp_acct { get; set; }
        public int? offset_acct { get; set; }
        public int close_acct2 { get; set; }
        public DateTime? close_date2 { get; set; }
        public int? fedi_acct { get; set; }
        public decimal fedi_min_amt { get; set; }
        public decimal fedi_min_fee { get; set; }
        public decimal fedi_add_amt { get; set; }
        public decimal fedi_add_fee { get; set; }
        public decimal fedi_max_fee { get; set; }
        public int service_acct { get; set; }
        public int no_int_acct { get; set; }
        public int oiu_acct { get; set; }
    }
}