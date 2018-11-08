using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFATEC.Models.Professor
{
    public class Professor
    {
        public Professor() { }

        public IList<Domain.Professor> Professores { get; set; }

        public IList<Domain.Professor> RetornaProfessores()
        {
            return new List<Domain.Professor>
            {
                new Domain.Professor{ Id = 1, Nome = "Grace", Turmas = new Turma.Turma().RetornaTurmas().Where(x => new int[]{1,2,3}.Contains(x.Id)).ToList()  },
                new Domain.Professor{ Id = 2, Nome = "Marta", Turmas = new Turma.Turma().RetornaTurmas().Where(x => new int[]{4}.Contains(x.Id)).ToList()  },
            };
        }
    }
}
