using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Selecao.Services
{
    interface IGenericsServices<T>
    {
        List<T> GetAll();

        T Save();
    }
}
