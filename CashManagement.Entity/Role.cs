﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CashManagement.Entity
{
    public partial class Role
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public bool Enable { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? CreateUser { get; set; }
    }
}