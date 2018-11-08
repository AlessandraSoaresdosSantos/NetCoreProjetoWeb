using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Aluno
    {
        /// <summary>
        /// Recupera ou define o Aluno - Id 
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Recupera ou define o Aluno - Nome
        /// </summary>
        public virtual string Nome { get; set; }

        /// <summary>
        /// Recupera ou define o Aluno - RG 
        /// </summary>
        public virtual string RG { get; set; }

        /// <summary>
        /// Recupera ou define o Aluno - Turma 
        /// </summary>
        public virtual Turma Turma { get; set; }

    }
}
