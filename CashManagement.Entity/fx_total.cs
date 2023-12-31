﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class fx_total
    {
        public string fund_no { get; set; }
        public DateTime tran_date { get; set; }
        public string base_curr_code { get; set; }
        public string account { get; set; }
        public string secu_desc1 { get; set; }
        public string secu_desc2 { get; set; }
        public decimal? cupon { get; set; }
        public DateTime? maturity { get; set; }
        public string security_id { get; set; }
        public string isin { get; set; }
        public string segment { get; set; }
        public string category { get; set; }
        public string sector { get; set; }
        public string industry { get; set; }
        /// <summary>
        /// 本月餘額股數/面額 =上月餘額股數/面額+本月買進股數/面額 -本月賣出的數量/面額
        /// </summary>
        public decimal? shares_units { get; set; }
        /// <summary>
        /// 本月餘額平均成本= 本月餘額攤銷後原幣總成本 /  本月餘額 (股數/面額) *100
        /// </summary>
        public decimal? price { get; set; }
        public string currency_code { get; set; }
        public string country { get; set; }
        /// <summary>
        /// 本月餘額攤銷後原幣總成本
        /// </summary>
        public decimal? cost_value { get; set; }
        /// <summary>
        /// 本月餘額攤銷後原幣總市價
        /// </summary>
        public decimal? market_value { get; set; }
        /// <summary>
        /// 本月餘額應收利息
        /// </summary>
        public decimal? net_accrued_income { get; set; }
        public decimal? unrealized_gain_loss { get; set; }
        public decimal? cost_value_base { get; set; }
        public decimal? market_value_base { get; set; }
        public decimal? net_accrued_income_base { get; set; }
        public decimal? unrealized_gain_loss_base { get; set; }
        public decimal? percent_of_unrealized_gain_loss_base { get; set; }
        public decimal? percent_of_total_portfolio { get; set; }
        /// <summary>
        /// 本月買進原幣成本= Net Amount  Local
        /// </summary>
        public decimal? buy_local_cost { get; set; }
        /// <summary>
        /// 本月買進台幣成本= Net Amount  Local * 月底評價匯率
        /// </summary>
        public decimal? buy_nt_cost { get; set; }
        /// <summary>
        /// 本月賣出面額/數量
        /// </summary>
        public decimal? sale_units { get; set; }
        public decimal? sale_local_cost { get; set; }
        public decimal? sale_nt_cost { get; set; }
        /// <summary>
        /// 本月賣出原幣成交金額
        /// </summary>
        public decimal? sale_net_Amount { get; set; }
        /// <summary>
        /// 本月賣出台幣成交金額
        /// </summary>
        public decimal? sale_net_Amount_nt { get; set; }
        /// <summary>
        /// 本月賣出原幣損益=原幣成交金額 - 本月賣出原幣成本
        /// </summary>
        public decimal? sale_net_Amount_profit { get; set; }
        /// <summary>
        /// 本月賣出台幣損益
        /// </summary>
        public decimal? sale_net_Amount_nt_profit { get; set; }
        /// <summary>
        /// 本月賣出匯兌損益
        /// </summary>
        public decimal? sale_exchange_profit { get; set; }
        /// <summary>
        /// 本月餘額本月原幣攤銷金額=本月餘額攤銷後原幣總成本-本月餘額攤銷前原幣總成本
        /// </summary>
        public decimal? month_amortisation_amt { get; set; }
        /// <summary>
        /// 本月餘額攤銷前原幣總成本=上月餘額原幣總成本 + 本月買進原幣成本 - 本月賣出原幣成本
        /// </summary>
        public decimal? month_amortisation_bf_cost { get; set; }
        /// <summary>
        /// 評價前台幣總成本 =上月餘額台幣總成本 + 本月買進台幣成本-本有賣出台幣成本
        /// </summary>
        public decimal? eval_bef_cost_nt { get; set; }
        /// <summary>
        /// 評價後台幣總成本=ROUND(本月餘額攤銷後原幣總成本 * 月底評價匯率,0)
        /// </summary>
        public decimal? eval_af_cost_nt { get; set; }
        /// <summary>
        /// 評價後台幣總市價=ROUND(本月餘額攤銷後原幣總市價 * 月底評價匯率,0)
        /// </summary>
        public decimal? eval_af_market_value_nt { get; set; }
        /// <summary>
        /// 評價本月匯兌損益=ROUND(本月餘額攤銷後原幣總成本 * 月底評價匯率,0) -(上月餘額台幣總成本 + 本月買進台幣成本-本有賣出台幣成本)
        /// </summary>
        public decimal? eval_af_exchange_profit { get; set; }
        /// <summary>
        /// 本月價差損益= 評價後台幣總市價  - 評價後台幣總成本
        /// --
        /// </summary>
        public decimal? price_diff_profile { get; set; }
        public string net_accrued_income_curr_code { get; set; }
        public decimal? market_value_cost { get; set; }
        public string security_type { get; set; }
    }
}