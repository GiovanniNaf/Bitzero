using System;
using AutoMapper;
using punto_venta.Models;
using punto_venta.Models.DTOS;
using punto_venta.Models.ModelBase;

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
              config.CreateMap<EnterpriseBranchCashDTO, EnterprisebranchcashModel>();
              config.CreateMap<EnterprisebranchcashModel, EnterpriseBranchCashDTO>();
              config.CreateMap<EnterpriseBranchOutputProductDTO, EnterpriseBranchOutputProductModel>();
              config.CreateMap<EnterpriseBranchOutputProductModel, EnterpriseBranchOutputProductDTO>();
              config.CreateMap<EnterprisebranchpurchaseDTO, EnterprisebranchpurchaseModel>();
              config.CreateMap<EnterprisebranchpurchaseModel, EnterprisebranchpurchaseDTO>();
              config.CreateMap<EnterprisebranchpurchasedetailDTO, EnterprisebranchpurchasedetailModel>();
              config.CreateMap<EnterprisebranchpurchasedetailModel, EnterprisebranchpurchasedetailDTO>();
              config.CreateMap<EnterprisebranchsaledeliveryDTO, EnterprisebranchsaledeliveryModel>();
              config.CreateMap<EnterprisebranchsaledeliveryModel, EnterprisebranchsaledeliveryDTO>();

          });

            return mappingConfig;
        }
    }
}
