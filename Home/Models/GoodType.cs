using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home.Models
{
    public class GoodType
    {
        //商品分类
        public int GoodTypeId { get; set; }
        //类型名称
        public string GoodTypeName { get; set; }
        //创建时间
        public string GoodTypeCreateTime { get; set; }
    }
}