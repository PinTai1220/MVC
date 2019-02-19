using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home.Models
{
    public class AddressInfo
    {
        //地址
        public int AddressId { get; set; }
        /// <summary>
        /// 地点名称
        /// </summary>
        public string AddressName { get; set; }
        /// <summary>
        /// 上级地点id
        /// </summary>
        public int ParentId { get; set; }
    }
}