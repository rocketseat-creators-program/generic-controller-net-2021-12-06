using GenericController;
using GenericController.Models;
using GenericController_ini.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericController_fim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriaPrimaController : GenericController<MateriaPrima>
    {
        public MateriaPrimaController(DbAplication context) : base(context)
        {
            // A palavra é prata, o silêncio é ouro
        }
    }
}
