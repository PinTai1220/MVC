using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home.Models
{
    public class ShoppingCart
    {
        //购物车
        public int ShoppingCartId { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public int UID { get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        public int GID { get; set; }
        /// <summary>
        /// 购买数量
        /// </summary>
        public int Num { get; set; }
        /// <summary>
        /// 状态（1正常，0删除）
        /// </summary>
        public int ShoppingCartState { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string ShoppingCartCreateTime { get; set; }
    }
}