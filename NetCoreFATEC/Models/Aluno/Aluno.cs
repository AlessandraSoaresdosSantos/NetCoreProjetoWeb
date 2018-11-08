using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFATEC.Models.Aluno
{
    public class Aluno
    {
        public Aluno() { }
        
        public IList<Domain.Aluno> Alunos { get; set; }

        public IList<Domain.Aluno> RetornaAlunos()
        {
            return new List<Domain.Aluno>
            {
                new Domain.Aluno{ Id = 1, Nome= "Marta Pereira", RG="23.985.985-63", Turma = new Turma.Turma().RetornaTurmas().FirstOrDefault(x => x.Id == 2) },
                new Domain.Aluno{ Id = 2, Nome= "João Pedro da Silva", RG="12.659.235-87", Turma = new Turma.Turma().RetornaTurmas().FirstOrDefault(x => x.Id == 1) },
                new Domain.Aluno{ Id = 3, Nome= "José Soares", RG="29.789.452-96", Turma = new Turma.Turma().RetornaTurmas().FirstOrDefault(x => x.Id == 1) },
                new Domain.Aluno{ Id = 4, Nome= "Zelia Nunes", RG="30.852.985-88", Turma = new Turma.Turma().RetornaTurmas().FirstOrDefault(x => x.Id == 2) },
            };
        }
    }
}
