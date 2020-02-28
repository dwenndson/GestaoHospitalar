using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Selecao.Models
{
    //Modelo de Enfermeiro com todos os dados 
    public class Enfermeiro
    {   
        [Key]
        [Required(ErrorMessage ="Campo Obrigatório")]
        [RegularExpression(@"(\d{3}\.\d{3}\.\d{3}\-\d{2}")]
        public string Cpf { get; set; }
        [MaxLength(60, ErrorMessage ="Valor Maximo é 60 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int Coren { get; set; }
        public DateTime DataNascimento { get; set; }
        [ForeignKey("Hospital")]
        public string IdHospital => Hospital.Cnpj;

        [Required(ErrorMessage = "Campo Obrigatório")]
        public Hospital Hospital { get; set; }
        public bool Active { get; internal set; }
    }
}
