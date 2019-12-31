using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppli.Models
{

    public class Shopping
    {
        /// <summary>
        /// 购物表
        /// </summary>
        [Key]
        public int Sid    { get; set; }//购物主键
        public int Sgid   { get; set; }//商品外键
        public int Shu    { get; set; }//用户外键

    }
}
