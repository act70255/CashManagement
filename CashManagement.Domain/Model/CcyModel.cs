//using CashManagement.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashManagement.Domain.Model
{
    public class CcyModel
    {
        public string ccy { get; set; }

        public string ccy_name { get; set; }

        public string ccy_e_name { get; set; }

        public decimal int_base_days { get; set; }

        public decimal fraction_num { get; set; }

        public decimal cash_fraction_num { get; set; }

        public decimal swap_fraction_num { get; set; }

        public string country_code { get; set; }
    }
}
