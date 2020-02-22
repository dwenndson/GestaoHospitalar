using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd_Selecao.Models;

namespace BackEnd_Selecao.Repository
{
    public interface IEnfermeirosRepository : IGenericsRepository <Enfermeiro>
    {
        Enfermeiro GetByCpf(string Cpf);
    }
}
