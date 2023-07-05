using System;
using System.Collections.Generic;
using System.Text;

namespace CashManagement.Repository
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            ID = Guid.NewGuid().ToString();
            CreateTime = DateTime.Now;
            //var props = this.GetType().GetProperties();
            //foreach (var prop in props)
            //{

            //}
        }

        public virtual string ID { get; set; }
        public virtual DateTime CreateTime { get; set; }
        public virtual DateTime? UpdateTime { get; set; }
    }
}
