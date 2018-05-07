using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace McardsBanco.Models
{
    public class Marca
    {
        [Key]
        public int Id_Marca { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Descricao { get; set; }
    }
}