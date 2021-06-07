using InventorySystem.Model.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystem.Aplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticuloController : ControllerBase
    {        
        private Model.MArticulo.IArticuloRepository _ArticuloRepository = new Model.MArticulo.ArticuloModel();
        [HttpGet]
        public ActionResult<List<Articulo>> Get()
        {
            List<Articulo> Articulos =  _ArticuloRepository.GetAllArticulo();
            return Ok(Articulos);
        }
    }
}
