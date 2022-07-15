using DailyMutualFundNAV.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DailyMutualFundNAV.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MutualFundNavController : ControllerBase
    {
        private readonly IMutualFundRepository _mutualFundRepository;
        public MutualFundNavController(IMutualFundRepository mutualFundRepository)
        {
            _mutualFundRepository = mutualFundRepository;
        }
        // GET api/<MutualFundNavController>/5
        [HttpGet("{fundName}")]
        public IActionResult GetDailyMutualFundNav (string fundName)
        {
            if (string.IsNullOrEmpty(fundName))
            {
                return BadRequest();
            }
            var funds = _mutualFundRepository.GetMutualFundNav(fundName);
            if (funds == null)
            {
                return NoContent();
            }
            return Ok(funds);
        }
    }
}
