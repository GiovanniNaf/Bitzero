using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using punto_venta.Data;
using punto_venta.Entidades;
using punto_venta.Models;
using punto_venta.Models.DTOS;
using punto_venta.Models.ModelBase;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace punto_venta.Controllers
{
    [Route("api/[controller]")]
    public class EnterprisebranchsaledeliveryController : Controller
    {
        private IMapper _mapper;
        public readonly AplicationDbContext _db;
        protected ReponseDTO _response;

        public EnterprisebranchsaledeliveryController(AplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
            _response = new ReponseDTO();

        }

        //-------------------CRUD--------------------------//

        //--------------CREATE-----------------------------//
        [Authorize]
        [HttpPost("Register")]
        public async Task<EnterprisebranchsaledeliveryDTO> Post(EnterprisebranchsaledeliveryDTO enterDTO)
        {
            EnterprisebranchsaledeliveryModel CEnterPriseDelivery = _mapper.Map<EnterprisebranchsaledeliveryDTO, EnterprisebranchsaledeliveryModel>(enterDTO);


            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_Insertenterprisebranchsaledelivery
                    @id_enterprise ={CEnterPriseDelivery.IdEnterprise},
	                @id_enterpriseBranch ={CEnterPriseDelivery.IdEnterpriseBranch},
	                @id_enterpriseBranchSale ={CEnterPriseDelivery.IdEnterpriseBranchSale},
	                @id_user={CEnterPriseDelivery.IdUser},
	                @fldrecordDate = {CEnterPriseDelivery.FldrecordDate},
	                @fldobservation = {CEnterPriseDelivery.Fldobservation}                
                                                    ");

            return _mapper.Map<EnterprisebranchsaledeliveryModel, EnterprisebranchsaledeliveryDTO>(CEnterPriseDelivery);
        }


        //--------------READ--------------------------------//
        [Authorize]
        [HttpGet("Lista")]
        public async Task<IEnumerable<ObtenerEnterprisebranchsaledelivery>> Get()
        {

            return await _db.Set<ObtenerEnterprisebranchsaledelivery>().ToListAsync();
        }



        //----------------UPDATE----------------------------//
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUpdate(EnterprisebranchsaledeliveryDTO enterDTO, int id)
        {
            EnterprisebranchsaledeliveryModel CEnterPriseDelivery = _mapper.Map<EnterprisebranchsaledeliveryDTO, EnterprisebranchsaledeliveryModel>(enterDTO);

            if (id != CEnterPriseDelivery.IdEnterprise)
            {
                return BadRequest();
            }


            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_Updateenterprisebranchsaledelivery
                    @id_enterprise ={CEnterPriseDelivery.IdEnterprise},
	                @id_enterpriseBranch bigint={CEnterPriseDelivery.IdEnterpriseBranch},
	                @id_enterpriseBranchSale ={CEnterPriseDelivery.IdEnterpriseBranchSale},
	                @id_user bigint={CEnterPriseDelivery.IdUser},
	                @fldrecordDate = {CEnterPriseDelivery.FldrecordDate},
	                @fldobservation = {CEnterPriseDelivery.Fldobservation}                
                                                    ");


            return Ok("Actulizado correctamente");
        }

        //---------------------------DELETE------------------------//
        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> delete(EnterprisebranchsaledeliveryDTO enterDTO)
        {
            EnterprisebranchsaledeliveryModel CEnterPriseDelivery = _mapper.Map<EnterprisebranchsaledeliveryDTO, EnterprisebranchsaledeliveryModel>(enterDTO);

            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_Deleteenterprisebranchsaledelivery
                    @id_enterprise = {CEnterPriseDelivery.IdEnterprise}");
            return Ok("Eliminado correctamente");
        }
    }
}
