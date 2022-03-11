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

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace punto_venta.Controllers
{
    [Route("api/[controller]")]
    public class EnterprisebranchpurchasedetailController : Controller
    {
        private IMapper _mapper;
        public readonly AplicationDbContext _db;
        protected ReponseDTO _response;

        public EnterprisebranchpurchasedetailController(AplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
            _response = new ReponseDTO();

        }

        //-------------------CRUD--------------------------//

        //--------------CREATE-----------------------------//
        [Authorize]
        [HttpPost("Register")]
        public async Task<EnterprisebranchpurchasedetailDTO> Post(EnterprisebranchpurchasedetailDTO enterDTO)
        {
            EnterprisebranchpurchasedetailModel CEnterPrisedetail = _mapper.Map<EnterprisebranchpurchasedetailDTO, EnterprisebranchpurchasedetailModel>(enterDTO);


            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_Insertenterprisebranchpurchasedetail
                    @id_enterprise ={CEnterPrisedetail.IdEnterprise},
	                @id_enterpriseBranch ={CEnterPrisedetail.IdEnterpriseBranch},
	                @id_enterpriseBranchPurchase ={CEnterPrisedetail.IdEnterpriseBranchPurchase},
	                @id_enterpriseProduct ={CEnterPrisedetail.IdEnterpriseProduct},
	                @fldunitAmount ={CEnterPrisedetail.FldunitAmount},
	                @fldprice = {CEnterPrisedetail.Fldprice}
                                                    ");

            return _mapper.Map<EnterprisebranchpurchasedetailModel, EnterprisebranchpurchasedetailDTO>(CEnterPrisedetail);
        }


        //--------------READ--------------------------------//
        [Authorize]
        [HttpGet("Lista")]
        public async Task<IEnumerable<ObtenerEnterprisebranchpurchasedetail>> Get()
        {

            return await _db.Set<ObtenerEnterprisebranchpurchasedetail>().ToListAsync();
        }



        //----------------UPDATE----------------------------//
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUpdate(EnterprisebranchpurchasedetailDTO enterDTO, int id)
        {
            EnterprisebranchpurchasedetailModel CEnterPrisedetail = _mapper.Map<EnterprisebranchpurchasedetailDTO, EnterprisebranchpurchasedetailModel>(enterDTO);

            if (id != CEnterPrisedetail.IdEnterprise)
            {
                return BadRequest();
            }


            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_UpdateEnterprisebranchpurchasedetail
                    @id_enterprise ={CEnterPrisedetail.IdEnterprise},
	                @id_enterpriseBranch ={CEnterPrisedetail.IdEnterpriseBranch},
	                @id_enterpriseBranchPurchase ={CEnterPrisedetail.IdEnterpriseBranchPurchase},
	                @id_enterpriseProduct ={CEnterPrisedetail.IdEnterpriseProduct},
	                @fldunitAmount ={CEnterPrisedetail.FldunitAmount},
	                @fldprice = {CEnterPrisedetail.Fldprice}
                                                    ");




            return Ok("Actulizado correctamente");
        }

        //---------------------------DELETE------------------------//
        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> delete(EnterprisebranchpurchasedetailDTO enterDTO)
        {
            EnterprisebranchpurchasedetailModel CEnterPrisedetail = _mapper.Map<EnterprisebranchpurchasedetailDTO, EnterprisebranchpurchasedetailModel>(enterDTO);

            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_DeleteEnterpriseBranchPurchaseDetail
                    @id_enterprise = {CEnterPrisedetail.IdEnterprise}");
            return Ok("Eliminado correctamente");
        }
    }
}
