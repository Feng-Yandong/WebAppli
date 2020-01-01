using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppli.Models
{
    public class Addupto
    {
        /// <summary>
        /// 一个对多个订单详情表
        /// </summary>
        [Key]
        public int      Aid     { get; set; }        // 主键
        public string   Aoid    { get; set; }        // 订单外键
        public int?     Agid    { get; set; }        // 商品外键
        public int?     AsumN   { get; set; }        // 商品数量


    }
}
