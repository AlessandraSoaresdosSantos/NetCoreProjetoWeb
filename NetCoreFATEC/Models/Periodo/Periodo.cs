using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace NetCoreFATEC.Models.Periodo
{
    public class Periodo
    {
        public Periodo() { }

        public IList<Domain.Periodo> Periodos { get; set; }

        public IList<Domain.Periodo> RetornaPeriodos()
        {
            return new List<Domain.Periodo>
            {
                new Domain.Periodo { Id = 1, Nome="Manhã"},
                new Domain.Periodo { Id = 2, Nome="Tarde"},
                new Domain.Periodo { Id = 3, Nome="Noite"},
                new Domain.Periodo { Id = 4, Nome="Integral"}
            };
        }
    }
}
