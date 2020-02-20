using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd_Selecao.Models;

namespace BackEnd_Selecao.Repository
{
    interface IEnfermeirosRepository : IGenericsRepository <Enfermeiro>
    {
        Enfermeiro GetByCpf(string Cpf);
    }
}
