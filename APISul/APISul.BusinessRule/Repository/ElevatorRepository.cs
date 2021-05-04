using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using APISul.BusinessRule.Interface;
using APISul.Domain.Entity;
using Newtonsoft.Json;


namespace APISul.BusinessRule.Repository
{
    public class ElevatorRepository : IElevatorRepository
    {
        
        public List<Elevator> LoadJson()
        {
            List<Elevator> items  = new List<Elevator>();
            using (StreamReader r = new StreamReader("..\\Docs\\input.json"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<Elevator>>(json);
            }
            return items;
        }
        public List<int> andarMenosUtilizado()
        {
            List<Elevator> elevators = LoadJson();
            List<int> result = new List<int>();

            elevators.ForEach(
                e => result.Add(e.andar)
            );

            result = (from a in result
                        group a by a into g
                        where g.Count() <= 1
                        orderby g.Count() ascending
                        select g.Key).ToList();

            return result;
        }

        public List<char> elevadorMaisFrequentado()
        {
            List<Elevator> elevators = LoadJson();
            List<char> listEvators = new List<char>();
            List<char> result = new List<char>();
            elevators.ForEach(
                e => listEvators.Add(e.elevador)
            );

            listEvators = (from a in listEvators
                      group a by a into g
                      where g.Count() >= 2
                      orderby g.Count() descending
                      select g.Key).ToList();
            if(listEvators != null && listEvators.Count > 0)
            {
                result.Add(listEvators.First());
            }
            return result;
        }

        public List<char> elevadorMenosFrequentado()
        {
            List<Elevator> elevators = LoadJson();
            List<char> listElevators = new List<char>();
            List<char> result = new List<char>();
            
            elevators.ForEach(
                e => listElevators.Add(e.elevador)
            );

            listElevators = (from a in listElevators
                      group a by a into g
                      where g.Count() <= 1
                      orderby g.Count() ascending
                      select g.Key).ToList();
            if(listElevators != null && listElevators.Count > 0)
            {
                result.Add(listElevators.First());
            }
            return result;
        }

        public float percentualDeUsoElevadorA()
        {            
            List<Elevator> elevators = LoadJson();
            float result = ((float)(elevators.Where(x => x.elevador.Equals('A')).ToList().Count()) / elevators.Count()) * 100;
            return result;           
        }

        public float percentualDeUsoElevadorB()
        {
             List<Elevator> elevators = LoadJson();
             float result = ((float)(elevators.Where(x => x.elevador.Equals('B')).ToList().Count()) / elevators.Count()) * 100;
             return result;
        }

        public float percentualDeUsoElevadorC()
        {
             List<Elevator> elevators = LoadJson();            
             float result = ((float)(elevators.Where(x => x.elevador.Equals('C')).ToList().Count()) / elevators.Count()) * 100;
             return result;
        }

        public float percentualDeUsoElevadorD()
        {
            List<Elevator> elevators = LoadJson();

            float result = ((float)(elevators.Where(x => x.elevador.Equals('D')).ToList().Count()) / elevators.Count()) * 100;
            return result;
        }

        public float percentualDeUsoElevadorE()
        {
            List<Elevator> elevators = LoadJson();
            float result = ((float)(elevators.Where(x => x.elevador.Equals('E')).ToList().Count()) / elevators.Count()) * 100;
            return result;
        }

        public List<char> periodoMaiorFluxoElevadorMaisFrequentado()
        {
            List<Elevator> elevators = LoadJson();
            
            char elevadorMaisFrequentado = this.elevadorMaisFrequentado().FirstOrDefault();
            List<char> listPeriodoMaiorFluxoMaisFrequentado = new List<char>();
            List<char> result = new List<char>();
            
            listPeriodoMaiorFluxoMaisFrequentado = (from e in elevators
                            where e.elevador == elevadorMaisFrequentado
                            group e.turno by e.turno into g
                            orderby g.Count() descending
                            select g.Key).ToList();

            if(listPeriodoMaiorFluxoMaisFrequentado != null && listPeriodoMaiorFluxoMaisFrequentado.Count > 0)
            {
                result.Add(listPeriodoMaiorFluxoMaisFrequentado.First());
            }

            return result;
        }

        public List<char> periodoMaiorUtilizacaoConjuntoElevadores()
        {
            List<Elevator> elevators = LoadJson();
            List<char> listTurno = new List<char>();
            List<char> result = new List<char>();
            elevators.ForEach(
                    e => listTurno.Add(e.turno)
                );
        
            listTurno = (from p in listTurno
                    group p by p into g
                    orderby g.Count() descending
                    select g.Key).ToList();

            if(listTurno != null && listTurno.Count > 0)
            {
                result.Add(listTurno.First());
            }
            
            return result;
        }

        public List<char> periodoMenorFluxoElevadorMenosFrequentado()
        {
            List<Elevator> elevators = LoadJson();
            char elevadorMenosFrequentado = this.elevadorMenosFrequentado().First();
            List<char> result = (from e in elevators
                            where e.elevador == elevadorMenosFrequentado
                            group e.turno by e.turno into g
                            orderby g.Count() ascending
                            select g.Key).ToList();

            return result;
        }
    }
}