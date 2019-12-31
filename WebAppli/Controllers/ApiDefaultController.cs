using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppli.Models;
using Microsoft.EntityFrameworkCore;

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
      
    }
}