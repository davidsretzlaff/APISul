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
            List<int> andares = new List<int>();
            
            elevators.ForEach(e => andares.Add(e.andar));

            // Ordernar pelo andar - frequente
            var andaresMenosUtilizados = (from a in andares
                                          group a by a into grupo
                                          orderby grupo.Count() ascending
                                          select grupo.Key).ToList();

            return andaresMenosUtilizados.ToList();
        }

        public List<char> elevadorMaisFrequentado()
        {
            throw new System.NotImplementedException();
        }

        public List<char> elevadorMenosFrequentado()
        {
            throw new System.NotImplementedException();
        }

        public float percentualDeUsoElevadorA()
        {
            throw new System.NotImplementedException();
        }

        public float percentualDeUsoElevadorB()
        {
            throw new System.NotImplementedException();
        }

        public float percentualDeUsoElevadorC()
        {
            throw new System.NotImplementedException();
        }

        public float percentualDeUsoElevadorD()
        {
            throw new System.NotImplementedException();
        }

        public float percentualDeUsoElevadorE()
        {
            throw new System.NotImplementedException();
        }

        public List<char> periodoMaiorFluxoElevadorMaisFrequentado()
        {
            throw new System.NotImplementedException();
        }

        public List<char> periodoMaiorUtilizacaoConjuntoElevadores()
        {
            throw new System.NotImplementedException();
        }

        public List<char> periodoMenorFluxoElevadorMenosFrequentado()
        {
            throw new System.NotImplementedException();
        }
    }
}