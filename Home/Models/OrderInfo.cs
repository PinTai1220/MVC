using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home.Models
{
    public class OrderInfo
    {
        //订单表
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
        /// <summary>
        /// 收货人
        /// </summary>
        public string OTGName { get; set; }
        /// <summary>
        /// 联系方式
        /// </summary>
        public string OTGPhone { get; set; }
        /// <summary>
        /// 收货地址
        /// </summary>
        public string OTGAddress { get; set; }
    }
}