using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppli.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("cors")]//设置跨域处理的代理
    public class YouController : ControllerBase
    {
        
    }
}