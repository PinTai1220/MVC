using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home.Models
{
    public class SalesRecord
    {
        //销售记录表
        /// <summary>
        /// 标识列
        /// </summary>
        public int SalesRecordId { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public int UID { get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        public int GID { get; set; }
        /// <summary>
        /// 订单id
        /// </summary>
        public int OID { get; set; }
        /// <summary>
        /// 商品单价
        /// </summary>
        public int SGoodPrice { get; set; }
        /// <summary>
        /// 购买数量
        /// </summary>
        public int SGoodNum { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public double SumPrice { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public int SType { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string SCreateTime { get; set; }
    }
}