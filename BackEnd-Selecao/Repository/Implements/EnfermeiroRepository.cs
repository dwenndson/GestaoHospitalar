using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd_Selecao.DataBase;
using BackEnd_Selecao.Models;

namespace BackEnd_Selecao.Repository.Implements
{
    public class EnfermeiroRepository : IEnfermeirosRepository
    {
        private readonly Contexto _context;
        public EnfermeiroRepository(Contexto contexto) => _context = contexto;

        public List<Enfermeiro> GetAll()
        {
            List<Enfermeiro> enfermeiros =  _context.Enfermeiros.ToList();
            return enfermeiros;
        }

        public Enfermeiro GetByCpf(string Cpf)
        {
            return _context.Enfermeiros.FirstOrDefault(Enfermeiro => Enfermeiro.Cpf == Cpf);
        }

        public Enfermeiro Save(Enfermeiro En)
        {
            this._context.Enfermeiros.Add(En);
            this._context.SaveChanges();
            return En;
        }

        public Enfermeiro Update(Enfermeiro En)
        {
            this._context.Enfermeiros.Update(En);
            this._context.SaveChanges();
            return En;
        }

        public void Delete(Enfermeiro En)
        {
            Enfermeiro enfermeiro = this._context.Enfermeiros.Find(En.Cpf);
            this._context.Enfermeiros.Remove(enfermeiro);
        }

    }
}
