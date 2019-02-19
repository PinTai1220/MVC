using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home.Models
{
    public class Administrator
    {
        public int AdministratorId { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        public string AdministratorAccount { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string AdministratorPwd { get; set; }
        /// <summary>
        /// 发货人姓名
        /// </summary>
        public string DeliveryName { get; set; }
        /// <summary>
        /// 发货地址
        /// </summary>
        public string DeliveryAddress { get; set; }
        /// <summary>
        /// 发货人手机号
        /// </summary>
        public string DeliveryPhone { get; set; }
    }
}