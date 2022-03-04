using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
    public class EnterPriseBCashController : Controller
    {
        private IMapper _mapper;
        public readonly AplicationDbContext _db;
        protected ReponseDTO _response;

        public EnterPriseBCashController(AplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
            _response = new ReponseDTO();

        }

        //-------------------CRUD--------------------------//

        //--------------CREATE-----------------------------//
        [HttpPost("Register")]
        public async Task<EnterpriseBranchCashDTO> Post(EnterpriseBranchCashDTO enterDTO)
        {
            EnterprisebranchcashModel CEnterPriseBCash = _mapper.Map<EnterpriseBranchCashDTO, EnterprisebranchcashModel>(enterDTO);


            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_Insertenterprisebranchcash
                    @id_enterprise = {CEnterPriseBCash.IdEnterprise},
                    @id_enterpriseBranch = {CEnterPriseBCash.IdEnterpriseBranch},
                    @id_enterpriseBranchCash = {CEnterPriseBCash.IdEnterpriseBranchCash},
                    @fldname = {CEnterPriseBCash.Fldname}
                                                    ");

            return _mapper.Map<EnterprisebranchcashModel, EnterpriseBranchCashDTO>(CEnterPriseBCash);
        }


        //--------------READ--------------------------------//
        //[Authorize]
        [HttpGet("Lista")]
        public async Task<IEnumerable<ObtenerEnterPriseBranchCash>> Get()
        {

            return await _db.Set<ObtenerEnterPriseBranchCash>().ToListAsync();
        }



        //----------------UPDATE----------------------------//
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUpdate(EnterpriseBranchCashDTO enterDTO, int id)
        {
            EnterprisebranchcashModel CEnterPriseBCash = _mapper.Map<EnterpriseBranchCashDTO, EnterprisebranchcashModel>(enterDTO);

            if (id != CEnterPriseBCash.IdEnterprise)
            {
                return BadRequest();
            }

            


            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_UpdateEnterpriseBranchCach
                    @id_enterprise = {CEnterPriseBCash.IdEnterprise},
                    @id_enterpriseBranch = {CEnterPriseBCash.IdEnterpriseBranch},
                    @id_enterpriseBranchCash = {CEnterPriseBCash.IdEnterpriseBranchCash},
                    @fldname = {CEnterPriseBCash.Fldname}
                                                    ");

            

            return Ok("Actulizado correctamente");
        }

        //---------------------------DELETE------------------------//
        [HttpDelete]
        public async Task<IActionResult> delete(EnterpriseBranchCashDTO enterDTO)
        {
            EnterprisebranchcashModel CEnterPriseB = _mapper.Map<EnterpriseBranchCashDTO, EnterprisebranchcashModel>(enterDTO);

            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_DeleteenterpriseBranchCash
                    @id_enterprise = {CEnterPriseB.IdEnterprise}");
            return Ok("Eliminado correctamente");
        }
    }
}
