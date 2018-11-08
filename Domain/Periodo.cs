using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
public  class Periodo
    {
        /// <summary>
        /// Recupera ou define o Periodo - Id 
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Recupera ou define o Periodo - Nome
        /// </summary>
        public virtual string Nome { get; set; }

    }
}
