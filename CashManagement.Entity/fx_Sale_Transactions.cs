﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class fx_Sale_Transactions
    {
        public int sale_serial { get; set; }
        public DateTime tran_date { get; set; }
        public string account_number { get; set; }
        public string currency { get; set; }
        public string account_name { get; set; }
        public DateTime trade_date { get; set; }
        public DateTime settlement_date { get; set; }
        public string base_currency_code { get; set; }
        public string security_id { get; set; }
        public string securities_sold { get; set; }
        public string security_description2 { get; set; }
        public decimal? quantity { get; set; }
        public decimal cost_local { get; set; }
        public decimal principal_local { get; set; }
        public decimal income_local { get; set; }
        public string transaction_id { get; set; }
        public string transaction_type_code { get; set; }
        public string section { get; set; }
        public string security_type { get; set; }
    }
}