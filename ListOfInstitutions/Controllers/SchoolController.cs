using AutoMapper;
using ListOfInstitutions.DTO;
using ListOfInstitutions.IRepository;
using ListOfInstitutions.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListOfInstitutions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<SchoolController> _logger;
        private readonly IMapper _mapper;

        public SchoolController(IUnitOfWork unitOfWork, ILogger<SchoolController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetSchools()
        {
            try
            {
                var schools = await _unitOfWork.Schools.GetAll();
                var results = _mapper.Map<IList<DTO.SchoolDTO>>(schools);
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong in the {nameof(GetSchools)}");
                return StatusCode(500, "Internal Server Error, Please Try Again...");
            }
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetSchool(int id)
        {
            try
            {
                var school = await _unitOfWork.Schools.Get(q => q.Id == id, new List<string> { "Country" });
                var result = _mapper.Map<SchoolDTO>(school);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrog in the {nameof(GetSchool)}");
                return StatusCode(500, "Internal Server Error, Please Try Again...");                
            }
        }
    }
}
