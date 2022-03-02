using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using punto_venta.Models;
using punto_venta.Models.DTOS;

namespace punto_venta.Repositorio
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioDTO>> GetUsarios();

        Task<UsuarioDTO> GetUsuarioById();

        Task<UsuarioDTO> CreateUpdate(UsuarioDTO usuarioDto );

        Task<bool> DeleteCliente(int id);

        Task<string> Login(string username, string password);

        Task<bool> UserExiste(string username);

    }
}
