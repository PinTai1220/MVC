using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home.Models
{
    public class TakeGoodsInfo
    {
        public int TGId { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public int UID { get; set; }
        /// <summary>
        /// 收货人姓名
        /// </summary>
        public string TGName { get; set; }
        /// <summary>
        /// 收货地址
        /// </summary>
        public string TGAddress { get; set; }
        /// <summary>
        /// 收货人手机号
        /// </summary>
        public string TGPhone { get; set; }
        /// <summary>
        /// 创建时间(yyyy-MM-dd hh:mm:ss)
        /// </summary>
        public string TGCreateTime { get; set; }
    }
}