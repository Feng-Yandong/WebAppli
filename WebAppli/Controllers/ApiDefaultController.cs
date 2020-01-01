using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppli.Models;

namespace WebAppli.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("cors")]//设置跨域处理的代理
    public class ApiDefaultController : ControllerBase

    {
        public CRMContext db;
        public ApiDefaultController(CRMContext db) 
        {
            this.db = db; 
        }

  
        /// 添加鲜花////
     
        public int Addhua(Goods goods)
        {
              db.Goods.Add(goods);
              return db.SaveChanges();
        }

        /// <summary>
        /// 显示鲜花
        /// </summary>
        /// <returns></returns>
        public List<Goods> Selhua()
        {
            var linq = from s in db.Goods
                       where s.Gtai == 0
                       select s;
            return linq.ToList();
        }

  



    }
}