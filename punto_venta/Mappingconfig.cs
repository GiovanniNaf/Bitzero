using System;
using AutoMapper;
using punto_venta.Models;
using punto_venta.Models.DTOS;

namespace punto_venta
{
    public class Mappingconfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
          {
              config.CreateMap<UsuarioDTO, sp_InsertUser>();
              config.CreateMap<sp_InsertUser, UsuarioDTO>();
              config.CreateMap<LoginDTO, LoginModel>();
              config.CreateMap<LoginModel, LoginDTO>();
              config.CreateMap<EnterDTO, EnterModel>();
              config.CreateMap<EnterModel, EnterDTO>();
              config.CreateMap<EnterPriseBranchDTO, EnterpriseBrainchModel>();
              config.CreateMap<EnterpriseBrainchModel, EnterPriseBranchDTO>();
          });

            return mappingConfig;
        }
    }
}
