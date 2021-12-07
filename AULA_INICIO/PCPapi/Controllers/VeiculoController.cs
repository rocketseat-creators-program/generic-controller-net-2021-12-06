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
    public class VeiculoController : GenericController<Veiculo,string>
    {
        public VeiculoController(DbAplication context): base(context) { }

    }
}
