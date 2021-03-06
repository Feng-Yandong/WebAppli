﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppli.Models
{
    public class Location
    {
        /// <summary>
        /// 收货表
        /// </summary>
        [Key]
        public int      Lid      { get; set; }     //收货主键
        public string   Lname    { get; set; }     //收货姓名
        public string   Lphone   { get; set; }     //收货人电话
        public string   Lonation { get; set; }     //收货地址
    }
}
