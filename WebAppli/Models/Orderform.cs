using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppli.Models
{
    public class Orderform
    {
        /// <summary>
        /// 订单表
        /// </summary>
        [Key]
        public int      Oid     { get; set; }// 订单主键
        public string   Orders  { get; set; }//订单号
        public DateTime Otime   { get; set; }//订单时间
        public int      Oshou   { get; set; }//收货与未收货
        public int      Aowid   { get; set; }// 用户外键
        public int      Alid    { get; set; }// 收货外键

    }
}
