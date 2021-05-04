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

        [HttpGet("elevadorMaisFrequentado")]
        public List<char> elevadorMaisFrequentado()
        {
            return _elevatorService.elevadorMaisFrequentado();
        }
        
        [HttpGet("elevadorMenosFrequentado")]
        public List<char> elevadorMenosFrequentado()
        {
           return _elevatorService.elevadorMenosFrequentado();
        }

        [HttpGet("percentualDeUsoElevadorA")]
        public float percentualDeUsoElevadorA()
        {            
           return _elevatorService.percentualDeUsoElevadorA();
        }

        [HttpGet("percentualDeUsoElevadorB")]
        public float percentualDeUsoElevadorB()
        {
            return _elevatorService.percentualDeUsoElevadorB();
        }

        [HttpGet("percentualDeUsoElevadorC")]
        public float percentualDeUsoElevadorC()
        {
            return _elevatorService.percentualDeUsoElevadorC();
        }

        [HttpGet("percentualDeUsoElevadorD")]
        public float percentualDeUsoElevadorD()
        {
            return _elevatorService.percentualDeUsoElevadorD();
        }

        [HttpGet("percentualDeUsoElevadorE")]
        public float percentualDeUsoElevadorE()
        {
            return _elevatorService.percentualDeUsoElevadorE();
        }
        //erada
        [HttpGet("periodoMaiorFluxoElevadorMaisFrequentado")]
        public List<char> periodoMaiorFluxoElevadorMaisFrequentado()
        {
            return _elevatorService.periodoMaiorFluxoElevadorMaisFrequentado();
        }

        
        [HttpGet("periodoMaiorUtilizacaoConjuntoElevadores")]
        public List<char> periodoMaiorUtilizacaoConjuntoElevadores()
        {
            return _elevatorService.periodoMaiorUtilizacaoConjuntoElevadores();
        }

        [HttpGet("periodoMenorFluxoElevadorMenosFrequentado")]
        public List<char> periodoMenorFluxoElevadorMenosFrequentado()
        {
            return _elevatorService.periodoMenorFluxoElevadorMenosFrequentado();
        }
    }
}