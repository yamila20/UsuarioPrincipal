using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuarioPrincipal.Models;
using UsuarioPrincipal.Models.Respons;
using UsuarioPrincipal.Models.ViewModels;

namespace UsuarioPrincipal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()//para mostrar el nombre de usuario
        {
            Respuesta oRespuesta = new Respuesta();
            oRespuesta.Exito = 0;//0 es si no entra a la base de datos
            try
            {
                using (mintContext db = new mintContext())
                {
                    var nombre = db.Usuarios.ToList();
                    oRespuesta.Exito = 1;//no hubo problemas en la base de datos
                    oRespuesta.data = nombre;
                }
            }
            catch(Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }

        [HttpPost]
        public IActionResult Add()
        {

        }
    }
}
