using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public class Professor
    {
        /// <summary>
        /// Recupera ou define o Professor - Id 
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Recupera ou define o Professor - Nome
        /// </summary>
        public virtual string Nome { get; set; }

        /// <summary>
        /// Recupera ou define o Professor - Nome
        /// </summary>
        public virtual IList<Turma> Turmas { get; set; }
    }
}
