using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using punto_venta.Models;
using punto_venta.Validacion;
using System;
using System.Threading.Tasks;

namespace punto_venta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly Models.db_a81d65_bitzerobdContext _db;
      


        public HomeController(db_a81d65_bitzerobdContext db)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<IActionResult> Post( sp_InsertUser Cuser)
        {
            var mensaje = "";
           


            if (ModelState.IsValid)
            {
                await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_InsertUser
                    @id_user = {Cuser.IdUser},
                    @id_userType = {Cuser.IdUserType},
                    @id_userStatus ={Cuser.IdUserStatus},
                    @fldpassword = {Cuser.Fldpassword},
                    @fldemailAccount = {Cuser.FldemailAccount},
                    @fldname = {Cuser.Fldname},
                    @fldlastname = {Cuser.FldlastName},
                    @fldfirstname = {Cuser.FldfirstName}
                                ");
                mensaje = ($"Se guardo correctamente con ID: { Cuser.IdUser}");
                return Ok(mensaje);
            }

            else
            {
                return BadRequest();
            }

            
        }

        [HttpDelete]
        public async Task<IActionResult> delete(sp_DeleteUser deleteuser)
        {
            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_DeleteUser
                    @id_user = {deleteuser.IdUser}");
            return Ok("Eliminado correctamente");

        }
    }
}
