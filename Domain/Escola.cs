using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public class Escola
    {
        /// <summary>
        /// Recupera ou define o Escola - Id 
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Recupera ou define o Escola - Nome
        /// </summary>
        public virtual string Nome { get; set; }

        /// <summary>
        /// Recupera ou define o Escola - Nome
        /// </summary>
        public virtual string Endereco { get; set; }
    }
}
