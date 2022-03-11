using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using punto_venta.Data;
using punto_venta.Models;
using punto_venta.Models.DTOS;
using punto_venta.Repositorio;


namespace punto_venta.Controllers
{
    [Route("api/[controller]")]
    public class EnterPriseController :Controller
    {

        private IMapper _mapper;
        public readonly AplicationDbContext _db;
        protected ReponseDTO _response;

        public EnterPriseController(AplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
            _response = new ReponseDTO();
            
        }

        //-------------------CRUD--------------------------//

        //--------------CREATE-----------------------------//
        [Authorize]
        [HttpPost("Register")]
        public async Task<EnterDTO> Post(EnterDTO enterDTO)
        {
            EnterModel CEnter = _mapper.Map<EnterDTO, EnterModel>(enterDTO);
            

            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_InsertEnter
                    
                    @id_state = {CEnter.IdState},
                    @id_municipality ={CEnter.IdMunicipality},
                    @fldname= {CEnter.Fldname},
                    @fldlocality = {CEnter.Fldlocality},
                    @fldstreet = {CEnter.Fldstreet},
                    @fldnumber = {CEnter.Fldnumber},
                    @fldpostCode  = {CEnter.FldpostCode},
                    @fldphoneNumber  = {CEnter.FldphoneNumber},
                    @fldemail   = {CEnter.Fldemail},
                    @fldpageWeb = {CEnter.FldpageWeb}
                                ");

            return _mapper.Map<EnterModel, EnterDTO>(CEnter);
        }


        //--------------READ--------------------------------//
        [Authorize]
        [HttpGet("Lista")]
        public async Task<IEnumerable<ObtenerEnter>> Get()
        {

            return await _db.Set<ObtenerEnter>().ToListAsync();
        }



        //----------------UPDATE----------------------------//
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUpdate(EnterDTO enterDTO, int id)
        {
            EnterModel CEnter = _mapper.Map<EnterDTO, EnterModel>(enterDTO);


            if (id != CEnter.IdEnterprise)
            {
                return BadRequest();
            }
            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_UpdateEnter
                    @id_enterprise = {CEnter.IdEnterprise},
                    @id_state = {CEnter.IdState},
                    @id_municipality ={CEnter.IdMunicipality},
                    @fldname= {CEnter.Fldname},
                    @fldlocality = {CEnter.Fldlocality},
                    @fldstreet = {CEnter.Fldstreet},
                    @fldnumber = {CEnter.Fldnumber},
                    @fldpostCode  = {CEnter.FldpostCode},
                    @fldphoneNumber  = {CEnter.FldphoneNumber},
                    @fldemail   = {CEnter.Fldemail},
                    @fldpageWeb = {CEnter.FldpageWeb}") ;

            return Ok("Actulizado");
        }

        //---------------------------DELETE------------------------//
        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> delete(EnterDTO enterDTO)
        {
            EnterModel CEnter = _mapper.Map<EnterDTO, EnterModel>(enterDTO);

            await _db.Database.ExecuteSqlInterpolatedAsync($@"EXEC sp_DeleteEnter
                    @id_enterprise = {CEnter.IdEnterprise}");
            return Ok("Eliminado correctamente");
        }

    }
}
