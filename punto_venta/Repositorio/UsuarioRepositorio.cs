using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using punto_venta.Data;
using punto_venta.Models;
using punto_venta.Models.DTOS;

namespace punto_venta.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public readonly AplicationDbContext _db;
        private IMapper _mapper;

        public UsuarioRepositorio(AplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<UsuarioDTO> CreateUpdate(UsuarioDTO oUsuario)
        {
            sp_InsertUser Cuser = _mapper.Map<UsuarioDTO, sp_InsertUser>(oUsuario);
           

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
            return _mapper.Map<sp_InsertUser,UsuarioDTO >(Cuser);
           
        }

        public Task<bool> DeleteCliente(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UsuarioDTO>> GetUsarios()
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioDTO> GetUsuarioById()
        {
            throw new NotImplementedException();
        }

        public async Task<string> Login(string username, string password)
        {
            
            var user = await _db.Users.FirstOrDefaultAsync(
                x => x.Fldname.ToLower().Equals(username.ToLower()));

            var pass = await _db.Users.FirstOrDefaultAsync(
                x => x.Fldpassword.ToLower().Equals(password.ToLower()));

            if (user == null)
            {
                return "nouser";
            }
            else if( pass == null)
            {
                return "Ingrese pass";
            }
            else
            {
                return "Ok";
            }

        }


        public async Task<bool> UserExiste(string username)
        {
            if (await _db.Users.AnyAsync(x => x.Fldname.ToLower().Equals(username.ToLower())))
            {
                return true;
            }
            return false;
        }

        
    }
}
