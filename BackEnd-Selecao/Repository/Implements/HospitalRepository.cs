using BackEnd_Selecao.DataBase;
using BackEnd_Selecao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Selecao.Repository.Implements
{
    public class HospitalRepository 
    {
        private readonly Contexto _contexto;

        public HospitalRepository (Contexto contexto) => _contexto = contexto;

        public List<Hospital> GetAll()
        {
            List<Hospital> Hospitals = _contexto.Hospitals.ToList();
            return Hospitals;
        }

        public Hospital GetByCnpj(string Cnpj)
        {
            return _contexto.Hospitals.FirstOrDefault(Hospital => Hospital.Cnpj == Cnpj);
        }

        public Hospital Save(Hospital En)
        {
            this._contexto.Hospitals.Add(En);
            this._contexto.SaveChanges();
            return En;
        }

        public Hospital Update(Hospital En)
        {
            this._contexto.Hospitals.Update(En);
            this._contexto.SaveChanges();
            return En;
        }

        public void Delete(String Cnpj)
        {
            Hospital Hospital = this._contexto.Hospitals.Find(Cnpj);
            this._contexto.Hospitals.Remove(Hospital);
        }

    }
}
