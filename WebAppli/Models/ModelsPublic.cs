using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppli.Models
{
    public class ModelsPublic
    {
        /// <summary>
        /// 商家信息/用户信息
        /// </summary>
        public int        Mid		     { get; set; } //--商家id
        public string     Mname	         { get; set; } //--商家名称
        public string     Mweixin	     { get; set; } //--用户微信号
        public string     Mphone	     { get; set; } //--商家手机号
        public string     Mpwd	         { get; set; } //--商家密码
        public string     Msite	         { get; set; } //--商家地址
        public string     Mimg	         { get; set; } //--商家照片

        /// <summary>                    
        /// -商品信息表                  
        /// </summary>                   
        public int        Gid		     { get; set; }// 商品主键
        public string     Gname		     { get; set; }// 商品名称
        public string     Gimg		     { get; set; }// 商品图片
        public string     Gdescribe	     { get; set; }// 商品描述
        public int        Gprice	     { get; set; }// 商品价格
        public int        Gsum		     { get; set; }// 商品数据
        public int        Gtai		     { get; set; }// 商品状态
        public int        Ginventory     { get; set; }// 商品库存
        public int        Gtype		     { get; set; }// 商品类型
        public int        Gint		     { get; set; }// 商品月销量
        public string     Gstring        { get; set; }// 备用1

        /// <summary>
        /// 商品类别表
        /// </summary>
        public int        Tid	         { get; set; }//商品主键
        public string     Tname          { get; set; }//类别名称
        public int        Tint		     { get; set; }//备用1
        public string     Tstring        { get; set; }//备用2

        /// <summary>
        /// 订单表
        /// </summary>
        public int         Oid		     { get; set; }// 订单主键
        public string      Orders	     { get; set; }//订单号
        public DateTime    Otime	     { get; set; }//订单时间
        public int         Oshou	     { get; set; }//收货与未收货
        public int         Aowid         { get; set; }// 用户外键

        //
        public int         Aid	         { get; set; }// 主键
        public string      Aoid	         { get; set; }// 订单外键
        public int         Agid	         { get; set; }// 商品外键


        /// <summary>
        /// 购物表
        /// </summary>
        public int         Sid	         { get; set; }//购物主键
        public int         Sgid          { get; set; }//商品外键
        public int         Shu	         { get; set; }//用户外键
        public int         Stai          { get; set; }//付款与未付款

    }
}
