using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFATEC.Models.Turma
{
    public class Turma
    {
        public Turma() { }

        public IList<Domain.Turma> Turmas { get; set; }


        public IList<Domain.Turma> RetornaTurmas()
        {
            return new List<Domain.Turma>
            {
                new Domain.Turma {Id =1 , Nome="A", Sala="3", Periodo =  new Periodo.Periodo().RetornaPeriodos().FirstOrDefault(x => x.Id == 1) },
                new Domain.Turma {Id =2 , Nome="B", Sala="4", Periodo = new Periodo.Periodo().RetornaPeriodos().FirstOrDefault(x => x.Id == 1) },
                new Domain.Turma {Id =3 , Nome="C", Sala="5", Periodo = new Periodo.Periodo().RetornaPeriodos().FirstOrDefault(x => x.Id == 2) },
                new Domain.Turma {Id =4 , Nome="D", Sala="6", Periodo = new Periodo.Periodo().RetornaPeriodos().FirstOrDefault(x => x.Id == 4) }
            };
        }


    }
}
