using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home.Models
{
    public class Courier
    {
        public int CourierId { get; set; }
        /// <summary>
        /// 订单id
        /// </summary>
        public int OID { get; set; }
        /// <summary>
        /// 快递号
        /// </summary>
        public string CourierNum { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string CourierCreateTime { get; set; }
    }
}