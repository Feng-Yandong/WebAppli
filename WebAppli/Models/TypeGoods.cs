using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppli.Models
{
    public class TypeGoods
    {
        /// <summary>
        /// 商品类别表
        /// </summary>
        [Key]
        public int    Tid      { get; set; }     //商品主键
        public string Tname    { get; set; }     //类别名称
        public string Tstring  { get; set; }     //类别详情
    }
}
