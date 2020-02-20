using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BackEnd_Selecao.Models
{
    public class Hospital
    {
        [RegularExpression(@"\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}")]
        public string Cnpj { get; set; }
        public string Nome { get; set; }

        [RegularExpression(@"^(RUA|Rua|R.|AVENIDA|Avenida|AV.|TRAVESSA|Travessa|TRAV.|Trav.) ([a-zA-Z_\s]+)[, ]+(\d+)\s?([-/\da-zDA-Z\\ ]+)?$")]
        public string Endereco { get; set; }

        public Boolean ValidarCnpj(string Cnpj)
        {
            if (Regex.IsMatch(Cnpj, @"\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}"))
                return true;
            else
                return false;
        }
    }
}
