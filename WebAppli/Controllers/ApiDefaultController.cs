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
        public DBHelper db;

        public ApiDefaultController(DBHelper db) { this.db = db; }


        /// <summary>
        /// 添加鲜花
        /// </summary>
        /// <param name="h">h传进Model类</param>
        /// <returns></returns>
        [Route("Addhua")]
         public int Addhua(ModelsPublic h)
         {
            string sql = $"insert Goods values('{h.Gname}','{h.Gimg}','{h.Gdescribe}','{h.Gprice}','{h.Gtai=0}','{h.Ginventory}','{h.Gtype}','{h.Gint=0}')";
            int i = db.ExecuteNonQuery(sql);
            return i;
         }
        
        /// <summary>
        /// 显示上架鲜花
        /// </summary>
        /// <returns></returns>
        [Route("Selhua")]
        public List<ModelsPublic> Selhua()
        {
            string sql = "select * from Goods where Gtai=0 ";
            return  db.GetToList<ModelsPublic>(sql);
        }




    }
}