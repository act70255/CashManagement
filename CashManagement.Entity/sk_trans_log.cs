﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class sk_trans_log
    {
        public string tran_no { get; set; }
        public string fund_no { get; set; }
        public DateTime tran_date { get; set; }
        public string sk_code { get; set; }
        public string acccate { get; set; }
        public string term { get; set; }
        public string sk_type { get; set; }
        public string group_code { get; set; }
        public string broker_code { get; set; }
        public string broker_type { get; set; }
        public string ref_no { get; set; }
        public decimal? volumn { get; set; }
        public decimal? price { get; set; }
        public decimal? total_amt { get; set; }
        public decimal? broker_comm { get; set; }
        public decimal? trans_tax { get; set; }
        public decimal? net { get; set; }
        public decimal? d_volumn { get; set; }
        public decimal? fund_cost { get; set; }
        public string action { get; set; }
        public string rec_status { get; set; }
        public string broker_ref { get; set; }
        public decimal? real_rate { get; set; }
        public float? insurance_rate { get; set; }
        public float? pricea { get; set; }
        public string tran_out { get; set; }
        public decimal? group_cost { get; set; }
        public DateTime? settle_date { get; set; }
        public decimal lcm_amt { get; set; }
        public decimal? co_cost { get; set; }
        public decimal? postal_tax { get; set; }
        public string check_no { get; set; }
        public DateTime insert_date { get; set; }
    }
}