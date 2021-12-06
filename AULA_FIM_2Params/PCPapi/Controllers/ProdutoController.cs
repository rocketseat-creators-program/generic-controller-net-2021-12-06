using GenericController;
using GenericController.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericController_ini.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : GenericController<Produto,int>
    {
        public ProdutoController(DbAplication context):base( context)
        {
            // A palavra é prata, o silêncio é ouro
        }

    }
}
