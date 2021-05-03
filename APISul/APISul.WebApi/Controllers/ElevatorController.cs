using System.Collections.Generic;
using APISul.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace APISul.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElevatorController : ControllerBase
    {
        private readonly IElevatorService _elevatorService;

        public ElevatorController(IElevatorService elevatorService)
        {
            _elevatorService = elevatorService;
        }

        [HttpGet("andarMenosUtilizado")]
        public List<int> andarMenosUtilizado()
        {
            return _elevatorService.andarMenosUtilizado();
        }
    }
}