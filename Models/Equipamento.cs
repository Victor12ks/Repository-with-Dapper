using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace McardsBanco.Models
{
    public class Equipamento
    {
        [Key]
        public int Id_Equipamento { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Tipo { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório")]
        //[Remote("ModeloUnico", "Equipamento", ErrorMessage = "Este N° de série já existe")]
        public string Modelo { get; set; }
        [Display(Name = "Marca")]
        [Required(ErrorMessage = "Este campo é obrigatório")]        
        public int Id_Marca { get; set; }
    }
}