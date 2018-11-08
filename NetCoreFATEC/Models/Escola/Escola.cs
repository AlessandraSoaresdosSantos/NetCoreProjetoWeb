using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace NetCoreFATEC.Models.Escola
{
    public class Escola
    {
        public Escola() { }
         
        public IList<Domain.Escola> Escolas { get; set; }
        public IList<Domain.Escola> RetornaEscolas()
        {
            return new List<Domain.Escola>
            {
                new Domain.Escola { Id = 1, Nome = "Fatec Ipiranga", Endereco = " R. Frei João, 59 - Vila Nair, São Paulo - SP, 04280-130" },
                new Domain.Escola { Id = 2, Nome = "Fatec São Paulo", Endereco = "Praça Cel. Fernando Prestes, 30 - Bom Retiro, São Paulo - SP, 01124-060" },
                new Domain.Escola { Id = 3, Nome = "Fatec São Roque", Endereco = "Rua Marechal Deodoro da Fonseca, 132 - Centro, São Roque - SP, 18130-070" },
                new Domain.Escola { Id = 4, Nome = "Fatec Santa Cecília", Endereco = "lameda Nothmann, 598 - Campos Elíseos, São Paulo - SP, 01216-000" }
            };
        }
    }
}
