using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppli.Models;

namespace WebAppli.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiDefaultController : ControllerBase
    {
        public CRMContext db;
        public ApiDefaultController(CRMContext db) 
        {
            this.db = db; 
        }


        /// <summary>
        /// 添加鲜花
        /// </summary>
        /// <param name="goods"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 显示鲜花
        /// </summary>
        /// <returns></returns>
        public List<Goods> Selhuja()
        {
            var linq = from s in db.Goods
                       where s.Gtai == 0
                       select s;
            return linq.ToList();
        }



    }
}