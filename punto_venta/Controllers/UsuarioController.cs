using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using punto_venta.Data;
using punto_venta.Entidades;
using punto_venta.Helper;
using punto_venta.Models;
using punto_venta.Models.DTOS;
using punto_venta.Models.ModelBase;
using punto_venta.Repositorio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace punto_venta.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {

        //public readonly IUsuarioRepositorio _usuarioRepositorio;
        public readonly AplicationDbContext _db;
        protected ReponseDTO _response;
        private IMapper _mapper;

        public readonly IConfiguration conf;

        //private readonly AplicationDbContext db;

        public UsuarioController (IMapper mapper, AplicationDbContext db, IConfiguration _conf)
        {
            //this.db = db;
           // _usuarioRepositorio = usuarioRepositorio;
            _db = db;
            _response = new ReponseDTO();
            conf = _conf;
            _mapper = mapper;

        }

       

        // GET: api/values
        [Authorize]
        [HttpGet("Lista")]
        public async Task<IEnumerable<ObtenerUsuario>> Get()
        {
            return await _db.Set<ObtenerUsuario>().ToListAsync();
        }



        // POST api/values
       // [Authorize]
        [HttpPost]
        public async Task<UsuarioDTO> Post(UsuarioDTO usuariodto)
        {
            sp_InsertUser Cuser = _mapper.Map<UsuarioDTO, sp_InsertUser>(usuariodto);


            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_Insertuser
                    @id_userType = {Cuser.IdUserType},
                    @id_userStatus ={Cuser.IdUserStatus},
                    @fldname = {Cuser.Fldname},
                    @fldlastname = {Cuser.FldlastName},
                    @fldfirstname = {Cuser.FldfirstName},
                    @fldpassword = {Cuser.Fldpassword},
                    @fldemailAccount = {Cuser.FldemailAccount}
                                ");

              return _mapper.Map<sp_InsertUser, UsuarioDTO>(Cuser);

            
        }

       
        [HttpPost("Login")]
        [AllowAnonymous]
        public ActionResult<object> Login([FromBody] LoginDTO persona)
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
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUpdate(UsuarioDTO usuariodto, int id)
        {
            sp_InsertUser Cuser = _mapper.Map<UsuarioDTO, sp_InsertUser>(usuariodto);

            if (id != Cuser.IdUser)
            {
                return BadRequest();
            }


            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_UpdateUser
                    @id_user = {Cuser.IdUser},
                    @id_userType = {Cuser.IdUserType},
                    @id_userStatus ={Cuser.IdUserStatus},
                    @fldname = {Cuser.Fldname},
                    @fldlastname = {Cuser.FldlastName},
                    @fldfirstname = {Cuser.FldfirstName},
                    @fldpassword = {Cuser.Fldpassword},
                    @fldemailAccount = {Cuser.FldemailAccount}
                       ");


            return Ok("Actulizado correctamente");
        }

       // [Authorize]
        [HttpDelete]
        public async Task<IActionResult> delete(sp_DeleteUser deleteuser)
        {
            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_DeleteUser
                    @id_user = {deleteuser.IdUser}");
            return Ok("Eliminado correctamente");
        }
    }
}
