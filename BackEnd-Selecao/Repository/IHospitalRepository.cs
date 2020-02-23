using BackEnd_Selecao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Selecao.Repository
{
    interface IHospitalRepository :  IGenericsRepository<Hospital>
    {
        Hospital GetCnpj(string cnpj);

    }
}
