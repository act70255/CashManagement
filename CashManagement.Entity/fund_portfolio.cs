﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class fund_portfolio
    {
        /// <summary>
        /// ??隞??
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
        /// ???迂
        /// </summary>
        public string FundName { get; set; }
        /// <summary>
        /// ??蝪∠迂
        /// </summary>
        public string FundSName { get; set; }
        /// <summary>
        /// ?撅祇?
        /// </summary>
        public string DepID { get; set; }
        /// <summary>
        /// 隤?蝯
        /// </summary>
        public string DepTeamID { get; set; }
        /// <summary>
        /// 韏瑕??交?
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// 蝯迫?交?
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// 撣喳???(Distribution:??, IndustryA:?喟絞A, IntSensitive:?抵?, IntSensitive B:?抵?B, Normal:銝?蝝?
        /// </summary>
        public string PolicyClass { get; set; }
        /// <summary>
        /// ??憿 (AFS嚗?靘?柴RD嚗漱??TM嚗???AM嚗瘣餌窗)
        /// </summary>
        public string AccountType { get; set; }
        /// <summary>
        /// 撟?
        /// </summary>
        public string Currency { get; set; }
        /// <summary>
        /// &apos;專案/信託&apos;
        /// </summary>
        public bool? IsProfessional { get; set; }
        /// <summary>
        /// &apos;交割方式&apos;
        /// </summary>
        public string SettleType { get; set; }
        /// <summary>
        /// ?????啣?
        /// </summary>
        public string InvestArea { get; set; }
        /// <summary>
        /// 銝??1, 憪?:2, OIU:3
        /// </summary>
        public string FundCategory { get; set; }
        /// <summary>
        /// 靽格鈭箏
        /// </summary>
        public string UpdateUser { get; set; }
        /// <summary>
        /// 靽格?交?
        /// </summary>
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// &apos;保管機構&apos;
        /// </summary>
        public string Custodian { get; set; }
        public string fund_level { get; set; }
    }
}