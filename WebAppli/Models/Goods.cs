using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppli.Models
{
    public class Goods
    {
        /// <summary>                    
        /// -商品信息表                  
        /// </summary>     
        [Key]
        public int    Gid        { get; set; }// 商品主键
        public string Gname      { get; set; }// 商品名称
        public string Gimg       { get; set; }// 商品图片
        public string Gdescribe  { get; set; }// 商品描述
        public int    Gprice     { get; set; }// 商品价格
        public int    Gsum       { get; set; }// 商品数据
        public int    Gtai       { get; set; }// 商品状态
        public int    Ginventory { get; set; }// 商品库存
        public int    Gtype      { get; set; }// 商品类型
        public int    Gint       { get; set; }// 商品月销量
        public string Gstring    { get; set; }// 备用1

    }
}
