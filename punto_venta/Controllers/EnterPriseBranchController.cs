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
    public class EnterPriseBranchController : Controller
    {
        private IMapper _mapper;
        public readonly AplicationDbContext _db;
        protected ReponseDTO _response;

        public EnterPriseBranchController(AplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
            _response = new ReponseDTO();

        }

        //-------------------CRUD--------------------------//

        //--------------CREATE-----------------------------//
        [Authorize]
        [HttpPost("Register")]
        public async Task<EnterPriseBranchDTO> Post(EnterPriseBranchDTO enterDTO)
        {
            EnterpriseBrainchModel CEnterPriseB = _mapper.Map<EnterPriseBranchDTO, EnterpriseBrainchModel>(enterDTO);


            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_InsertEnterpriseBranch
                    @id_enterprise = {CEnterPriseB.IdEnterprise},
                    @id_state = {CEnterPriseB.IdState},
                    @id_municipality = {CEnterPriseB.IdMunicipality},
                    @fldrfc ={CEnterPriseB.Fldrfc},
                    @fldhomoclave = {CEnterPriseB.Fldhomoclave},
                    @fldname= {CEnterPriseB.Fldname},
                    @fldlocality = {CEnterPriseB.Fldlocality},
                    @fldstreet = {CEnterPriseB.Fldstreet},
                    @fldnumber = {CEnterPriseB.Fldnumber},
                    @fldpostCode  = {CEnterPriseB.FldpostCode},
                    @fldphoneNumber  = {CEnterPriseB.FldphoneNumber},
                    @fldmovilNumber = {CEnterPriseB.FldmovilNumber},
                    @fldemail   = {CEnterPriseB.Fldemail},
                    @fldfiscalName = {CEnterPriseB.FldfiscalName},
                    @fldpasswordFiel = {CEnterPriseB.FldpasswordFiel},
                    @fldpasswordlnvoice = {CEnterPriseB.FldpasswordInvoice}
                                ");

            return _mapper.Map<EnterpriseBrainchModel, EnterPriseBranchDTO>(CEnterPriseB);
        }


        //--------------READ--------------------------------//
        [Authorize]
        [HttpGet("Lista")]
        public async Task<IEnumerable<ObtenerEnterPriseBranch>> Get()
        {

            return await _db.Set<ObtenerEnterPriseBranch>().ToListAsync();
        }



        //----------------UPDATE----------------------------//
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUpdate(EnterPriseBranchDTO enterDTO, int id)
        {
            EnterpriseBrainchModel CEnterPriseB = _mapper.Map<EnterPriseBranchDTO, EnterpriseBrainchModel>(enterDTO);


            if (id != CEnterPriseB.IdEnterprise)
            {
                return BadRequest();
            }
            
            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_UpdateEnterpriseBranch
                    @id_enterprise = {CEnterPriseB.IdEnterprise},
                    @id_enterpriseBranch = {CEnterPriseB.IdEnterpriseBranch},
                    @id_state = {CEnterPriseB.IdState},
                    @id_municipality = {CEnterPriseB.IdMunicipality},
                    @fldrfc ={CEnterPriseB.Fldrfc},
                    @fldhomoclave = {CEnterPriseB.Fldhomoclave},
                    @fldname= {CEnterPriseB.Fldname},
                    @fldlocality = {CEnterPriseB.Fldlocality},
                    @fldstreet = {CEnterPriseB.Fldstreet},
                    @fldnumber = {CEnterPriseB.Fldnumber},
                    @fldpostCode  = {CEnterPriseB.FldpostCode},
                    @fldphoneNumber  = {CEnterPriseB.FldphoneNumber},
                    @fldmovilNumber = {CEnterPriseB.FldmovilNumber},
                    @fldemail   = {CEnterPriseB.Fldemail},
                    @fldfiscalName = {CEnterPriseB.FldfiscalName},
                    @fldpasswordFiel = {CEnterPriseB.FldpasswordFiel},
                    @fldpasswordlnvoice = {CEnterPriseB.FldpasswordInvoice}
                                ");

            return Ok("Actulizado correctamente");
        }

        //---------------------------DELETE------------------------//
        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> delete(EnterPriseBranchDTO enterDTO)
        {
            EnterpriseBrainchModel CEnterPriseB = _mapper.Map<EnterPriseBranchDTO, EnterpriseBrainchModel>(enterDTO);

            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_DeleteEnterpriseBranch
                    @id_enterprise = {CEnterPriseB.IdEnterprise}");
            return Ok("Eliminado correctamente");
        }
    }
}
