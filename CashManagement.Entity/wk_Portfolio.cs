﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class wk_Portfolio
    {
        /// <summary>
        /// 投組代號
        /// </summary>
        public string FundID { get; set; }
        /// <summary>
        /// P Account
        /// </summary>
        public string PAccount { get; set; }
        /// <summary>
        /// GTI Account
        /// </summary>
        public string GTIAccount { get; set; }
        /// <summary>
        /// Code
        /// </summary>
        public string FundCode { get; set; }
        /// <summary>
        /// Symbol
        /// </summary>
        public string PortiaSymbol { get; set; }
        /// <summary>
        /// 投組名稱
        /// </summary>
        public string FundName { get; set; }
        /// <summary>
        /// 投組簡稱
        /// </summary>
        public string FundSName { get; set; }
        /// <summary>
        /// 投組層級
        /// </summary>
        public string FundLevel { get; set; }
        /// <summary>
        /// 所屬部門
        /// </summary>
        public string DepID { get; set; }
        /// <summary>
        /// 課/組別
        /// </summary>
        public string DepTeamID { get; set; }
        /// <summary>
        /// 起始日期
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// 終止日期
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// 帳冊別 (Distribution:分紅, IndustryA:傳統A, IntSensitive:利變, IntSensitive B:利變B, Normal:不分紅)
        /// </summary>
        public string PolicyClass { get; set; }
        /// <summary>
        /// 會計類別 (AFS：備供出售、TRD：交易目的、HTM：持有到期、NAM：無活絡)
        /// </summary>
        public string AccountType { get; set; }
        /// <summary>
        /// 幣別
        /// </summary>
        public string Currency { get; set; }
        /// <summary>
        /// 沖銷方法(0：Specific(指定法)、1：FIFO、2：LIFO、9：Pro Rata-Qty(平均法))
        /// </summary>
        public string SellingRule { get; set; }
        /// <summary>
        /// 資產策略
        /// </summary>
        public string AssetStra { get; set; }
        /// <summary>
        /// 期權保證金
        /// </summary>
        public decimal? OPTMargin { get; set; }
        /// <summary>
        /// 專案/信託(專案=1；信託=0)
        /// </summary>
        public bool? IsProfessional { get; set; }
        /// <summary>
        /// 交割方式 (Bond：國內交割、GlBond：國外交割)
        /// </summary>
        public string SettleType { get; set; }
        /// <summary>
        /// 債券類別-大類別
        /// </summary>
        public string BondType_Lv1 { get; set; }
        /// <summary>
        /// 一般:1, 委外:2, OIU:3
        /// </summary>
        public string FundCategory { get; set; }
        /// <summary>
        /// 結帳組別
        /// </summary>
        public string SettleGroup { get; set; }
        /// <summary>
        /// 保管機構
        /// </summary>
        public string Custodian { get; set; }
        /// <summary>
        /// 借券代號
        /// </summary>
        public string LendingAcc { get; set; }
        /// <summary>
        /// 建立人員
        /// </summary>
        public string CreateUser { get; set; }
        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 修改人員
        /// </summary>
        public string UpdateUser { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 投組資產分類
        /// </summary>
        public string AssetClass { get; set; }
        /// <summary>
        /// 投組投資地區
        /// </summary>
        public string InvestArea { get; set; }
    }
}