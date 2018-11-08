using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public class Turma
    {
        /// <summary>
        /// Recupera ou define o Turma - Id 
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Recupera ou define o Turma - Nome
        /// </summary>
        public virtual string Nome { get; set; }

        /// <summary>
        /// Recupera ou define o Turma - Sala
        /// </summary>
        public virtual string Sala { get; set; }

        /// <summary>
        /// Recupera ou define o Turma - Periodo
        /// </summary>
        public virtual Periodo Periodo { get; set; }


    }
}
