using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using punto_venta.Data;
using punto_venta.Entidades;
using punto_venta.Helper;
using punto_venta.Models;
using punto_venta.Models.DTOS;
using punto_venta.Repositorio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace punto_venta.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {

        public readonly IUsuarioRepositorio _usuarioRepositorio;
        public readonly AplicationDbContext _db;
        protected ReponseDTO _response;

        public readonly IConfiguration conf;

        //private readonly AplicationDbContext db;

        public UsuarioController (IUsuarioRepositorio usuarioRepositorio, AplicationDbContext db, IConfiguration _conf)
        {
            //this.db = db;
            _usuarioRepositorio = usuarioRepositorio;
            _db = db;
            _response = new ReponseDTO();
            conf = _conf;
        }

       

        // GET: api/values
        //[Authorize]
        [HttpGet("Lista")]
        public async Task<IEnumerable<ObtenerUsuario>> Get()
        {

            return await _db.Set<ObtenerUsuario>().ToListAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost ("Register")]
        public async Task<IActionResult> Post(UsuarioDTO usuariodto)
        {
            UsuarioDTO model = await _usuarioRepositorio.CreateUpdate(usuariodto);
            return Ok(model);
         
      
        }

       

        [HttpPost("Login")]
        [AllowAnonymous]
        public ActionResult<object> Login([FromBody] UsuarioDTO persona)
        {
            string secret = this.conf.GetValue<string>("Secret");
            var jwtHelper = new JWTHelper(secret);
            var token = jwtHelper.CreateToken(persona.Fldname);

            return Ok(new
            {
                ok = true,
                msg = "Logeado con exíto.",
                token
            });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete]
        public async Task<IActionResult> delete(sp_DeleteUser deleteuser)
        {
            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_DeleteUser
                    @id_user = {deleteuser.IdUser}");
            return Ok("Eliminado correctamente");
        }
    }
}
