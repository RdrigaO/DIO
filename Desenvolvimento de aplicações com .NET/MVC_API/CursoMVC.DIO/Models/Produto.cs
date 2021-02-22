using System;
using System.ComponentModel.DataAnnotations;

namespace CursoMVC.DIO.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = " O campo descrição é obrigatorio")]
        public string Descricao { get; set; }
        [Range(1, 10, ErrorMessage = "Valor fora da Faixa")]
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}