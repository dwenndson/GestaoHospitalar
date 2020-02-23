using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Selecao.Repository
{
    public interface IGenericsRepository<T>
    {
        List<T> GetAll();
        T Save(T t);
        T Update(T t);
        void Delete(string t);
    }
}
