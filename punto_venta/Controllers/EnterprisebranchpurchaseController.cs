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
    public class EnterprisebranchpurchaseController : Controller
    {
        private IMapper _mapper;
        public readonly AplicationDbContext _db;
        protected ReponseDTO _response;

        public EnterprisebranchpurchaseController(AplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
            _response = new ReponseDTO();

        }

        //-------------------CRUD--------------------------//

        //--------------CREATE-----------------------------//
        [Authorize]
        [HttpPost("Register")]
        public async Task<EnterprisebranchpurchaseDTO> Post(EnterprisebranchpurchaseDTO enterDTO)
        {
            EnterprisebranchpurchaseModel CEnterPrisePurchase = _mapper.Map<EnterprisebranchpurchaseDTO, EnterprisebranchpurchaseModel>(enterDTO);


            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_Insertenterprisebranchpurchase
                    @id_enterprise = {CEnterPrisePurchase.IdEnterprise},
                    @id_enterpriseBranch = {CEnterPrisePurchase.IdEnterpriseBranch},
                    @id_enterpriseProvider = {CEnterPrisePurchase.IdEnterpriseProvider},
                    @fldpurchaseDate= {CEnterPrisePurchase.FldpurchaseDate},
                    @fldinvoiceNumber={CEnterPrisePurchase.FldinvoiceNumber},
                    @fldinvoceDate = {CEnterPrisePurchase.FldinvoiceDate},
                    @fldentryDateToWarehouse = {CEnterPrisePurchase.FldentryDateToWarehouse},
                    @fldobservation = {CEnterPrisePurchase.Fldobservation}                    
                                                    ");

            return _mapper.Map<EnterprisebranchpurchaseModel, EnterprisebranchpurchaseDTO>(CEnterPrisePurchase);
        }


        //--------------READ--------------------------------//
        [Authorize]
        [HttpGet("Lista")]
        [Authorize]
        public async Task<IEnumerable<ObtenerEnterprisebranchpurchase>> Get()
        {

            return await _db.Set<ObtenerEnterprisebranchpurchase>().ToListAsync();
        }



        //----------------UPDATE----------------------------//
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutUpdate(EnterprisebranchpurchaseDTO enterDTO, int id)
        {
            EnterprisebranchpurchaseModel CEnterPrisePurchase = _mapper.Map<EnterprisebranchpurchaseDTO, EnterprisebranchpurchaseModel>(enterDTO);

            if (id != CEnterPrisePurchase.IdEnterprise)
            {
                return BadRequest();
            }

            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_Insertenterprisebranchpurchase
                    @id_enterprise = {CEnterPrisePurchase.IdEnterprise},
                    @id_enterpriseBranch = {CEnterPrisePurchase.IdEnterpriseBranch},
                    @id_enterpriseProvider = {CEnterPrisePurchase.IdEnterpriseProvider},
                    @fldpurchaseDate= {CEnterPrisePurchase.FldpurchaseDate},
                    @fldinvoiceNumber={CEnterPrisePurchase.FldinvoiceNumber},
                    @fldinvoceDate = {CEnterPrisePurchase.FldinvoiceDate},
                    @fldentryDateToWarehouse = {CEnterPrisePurchase.FldentryDateToWarehouse},
                    @fldobservation = {CEnterPrisePurchase.Fldobservation}                    
                                                    ");

            return Ok("Actulizado correctamente");
        }

        //---------------------------DELETE------------------------//
        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> delete(EnterprisebranchpurchaseDTO enterDTO)
        {
            EnterprisebranchpurchaseModel CEnterPriseB = _mapper.Map<EnterprisebranchpurchaseDTO, EnterprisebranchpurchaseModel>(enterDTO);

            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_DeleteEnterprisebranchpurchase
                    @id_enterprise = {CEnterPriseB.IdEnterprise}");
            return Ok("Eliminado correctamente");
        }
    }
}
