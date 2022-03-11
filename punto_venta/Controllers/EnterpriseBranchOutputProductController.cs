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
    public class EnterpriseBranchOutputProductController : Controller
    {
        private IMapper _mapper;
        public readonly AplicationDbContext _db;
        protected ReponseDTO _response;

        public EnterpriseBranchOutputProductController(AplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
            _response = new ReponseDTO();

        }

        //-------------------CRUD--------------------------//

        //--------------CREATE-----------------------------//
        [Authorize]
        [HttpPost("Register")]
        public async Task<EnterpriseBranchOutputProductDTO> Post(EnterpriseBranchOutputProductDTO enterDTO)
        {
            EnterpriseBranchOutputProductModel CEnterPriseB = _mapper.Map<EnterpriseBranchOutputProductDTO, EnterpriseBranchOutputProductModel>(enterDTO);


            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_Insertenterprisebranchoutputproduct
                    @id_enterprise = {CEnterPriseB.IdEnterprise},
                    @id_enterpriseBranch = {CEnterPriseB.IdEnterpriseBranch},
                    @IdEnterpriseBranchOutput = {CEnterPriseB.IdEnterpriseBranchOutput},
                    @id_enterpriseProduct = {CEnterPriseB.IdEnterpriseProduct},
                    @fldamount  = {CEnterPriseB.Fldamount}
                           ");

            return _mapper.Map<EnterpriseBranchOutputProductModel, EnterpriseBranchOutputProductDTO>(CEnterPriseB);
        }


        //--------------READ--------------------------------//
        [Authorize]
        [HttpGet("Lista")]
        public async Task<IEnumerable<ObtenerEnterpriseBranchOutputProduct>> Get()
        {

            return await _db.Set<ObtenerEnterpriseBranchOutputProduct>().ToListAsync();
        }



        //----------------UPDATE----------------------------//
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUpdate(EnterpriseBranchOutputProductDTO enterDTO, int id)
        {
            EnterpriseBranchOutputProductModel CEnterPriseB = _mapper.Map<EnterpriseBranchOutputProductDTO, EnterpriseBranchOutputProductModel>(enterDTO);


            if (id != CEnterPriseB.IdEnterprise)
            {
                return BadRequest();
            }

            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_Updateenterprisebranchoutputproduct
                    @id_enterprise = {CEnterPriseB.IdEnterprise},
                    @id_enterpriseBranch = {CEnterPriseB.IdEnterpriseBranch},
                    @id_enterpriseProduct = {CEnterPriseB.IdEnterpriseProduct},
                    @fldamount  = {CEnterPriseB.Fldamount}
                           ");

            return Ok("Actulizado correctamente");
        }

        //---------------------------DELETE------------------------//
        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> delete(EnterpriseBranchOutputProductDTO enterDTO)
        {
            EnterpriseBranchOutputProductModel CEnterPriseB = _mapper.Map<EnterpriseBranchOutputProductDTO, EnterpriseBranchOutputProductModel>(enterDTO);

            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_Deleteenterprisebranchoutputproduct
                    @id_enterprise = {CEnterPriseB.IdEnterprise}");
            return Ok("Eliminado correctamente");
        }
    }
}
