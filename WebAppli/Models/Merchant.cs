using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppli.Models
{
    public class Merchant
    {
        /// <summary>
        /// 商家信息/用户信息
        /// </summary>
        [Key]
        public int     Mid        { get; set; } //--商家id
        public int     Mid1       { get; set; } //--商家id
        public int     wxd        { get; set; } //--商家id
        public string  Mname      { get; set; } //--商家名称
        public string  Mweixin    { get; set; } //--用户微信号
        public string  Mphone     { get; set; } //--商家手机号
        public string  Mpwd       { get; set; } //--商家密码
        public string  Msite      { get; set; } //--商家地址
        public string  Mimg       { get; set; } //--商家照片
    }
}
