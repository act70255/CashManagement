﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class bd_chk_oversell
    {
        public DateTime tran_date { get; set; }
        public string bond_no { get; set; }
        public string acccate { get; set; }
        public string bond_kind { get; set; }
        public decimal? stock_par_value { get; set; }
        public decimal? buy_par_value { get; set; }
        public decimal? sell_par_value { get; set; }
    }
}