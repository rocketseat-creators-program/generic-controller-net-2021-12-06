using GenericController;
using GenericController.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericController_ini.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GaragemController : GenericController<Garagem,int>
    {
        public GaragemController(DbAplication context) : base(context) { }

    }
}
