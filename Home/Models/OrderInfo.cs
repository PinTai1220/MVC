using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home.Models
{
    public class OrderInfo
    {
        public int OrderId { get; set; }
        /// <summary>
        /// 订单号（日期yyyyMMddhhmmss）
        /// </summary>
        public string OrderNum { get; set; }
        /// <summary>
        /// 购物车id
        /// </summary>
        public int SCID { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public int OrderState { get; set; }
        /// <summary>
        /// 创建时间yyyy-MM-dd hh:mm:ss
        /// </summary>
        public string OrderCreateTime { get; set; }
    }
}