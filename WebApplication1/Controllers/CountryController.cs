using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.IRepository;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
         
        private readonly IUnitOfWork _UnitOfWork;

        private readonly  ILogger<CountryController> _Logger;
        private readonly IMapper _mapper;

        public CountryController(IUnitOfWork UnitOfWork, ILogger<CountryController > Logger, IMapper mapper)
        {
           _Logger = Logger;
            _UnitOfWork = UnitOfWork;
            _mapper = mapper;

        }
        [HttpGet]
        public async Task<IActionResult> GetCoutries() {

            try { 
                var countries = await _UnitOfWork.Countries.GetAll();
                var result = _mapper.Map<IList<CountryDTO>>(countries );
                return Ok(countries);
            } 

             
            catch (System.Exception ex) 
            {
                _Logger.LogError( $"Something went wrong in the {nameof(GetCoutries)}: {ex}");
                return StatusCode(500, "Internal server error. Please try again later.");
            }

          
             
           
        }


        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCountry(int id)
        {
            try
            {
                var countries =  await _UnitOfWork.Countries.Get(q => q.Id == id, new List<string> { "Hotels" });
                var result = _mapper.Map<CountryDTO>(countries);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                _Logger.LogError($"Something went wrong in the {nameof(GetCountry)}: {ex}");
                return StatusCode(500, "Internal server error. Please try again later.");
            }
        }
    }
}
