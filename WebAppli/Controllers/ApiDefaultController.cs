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

    }
}