using System.Collections.Generic;
using APISul.BusinessRule.Interface;
using APISul.Service.Interface;

namespace APISul.Service.Service
{
    public class ElevatorService : IElevatorService
    {
        private readonly IElevatorRepository _elevatorRepository;

        public ElevatorService(IElevatorRepository elevatorRepository)
        {
            _elevatorRepository = elevatorRepository;
        }
        public List<int> andarMenosUtilizado()
        {
            return _elevatorRepository.andarMenosUtilizado();
        }

        public List<char> elevadorMaisFrequentado()
        {
            return _elevatorRepository.elevadorMaisFrequentado();
        }

        public List<char> elevadorMenosFrequentado()
        {
            return _elevatorRepository.elevadorMenosFrequentado();
        }

        public float percentualDeUsoElevadorA()
        {
            return _elevatorRepository.percentualDeUsoElevadorA();
        }

        public float percentualDeUsoElevadorB()
        {
            return _elevatorRepository.percentualDeUsoElevadorB();
        }

        public float percentualDeUsoElevadorC()
        {
            return _elevatorRepository.percentualDeUsoElevadorC();
        }

        public float percentualDeUsoElevadorD()
        {
            return _elevatorRepository.percentualDeUsoElevadorD();
        }

        public float percentualDeUsoElevadorE()
        {
            return _elevatorRepository.percentualDeUsoElevadorE();
        }

        public List<char> periodoMaiorFluxoElevadorMaisFrequentado()
        {
            return _elevatorRepository.periodoMaiorFluxoElevadorMaisFrequentado();
        }

        public List<char> periodoMaiorUtilizacaoConjuntoElevadores()
        {
            return _elevatorRepository.periodoMaiorUtilizacaoConjuntoElevadores();
        }

        public List<char> periodoMenorFluxoElevadorMenosFrequentado()
        {
            return _elevatorRepository.periodoMenorFluxoElevadorMenosFrequentado();
        }
    }
}