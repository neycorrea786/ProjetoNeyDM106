using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace ProjetoNey.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "O tamanho minimo do nome é 3 caracteres")]
        public string nome { get; set; }

        public string cor { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "O tamanho minimo do modelo é 2 caracteres")]
         public string modelo { get; set; }

        [Required]
        [StringLength(8, ErrorMessage = "O tamanho máximo do código é 8 caracteres")]
        public string codigo { get; set; }

        [Range(0.1, 999, ErrorMessage = "o preco deve ser entre 0.1 a 999")]
        public decimal preco { get; set; }

        [Range(0.1, 999, ErrorMessage = "o peso deve ser entre 0.1 a 999")]
        public float peso { get; set; }

        [Range(0.1, 999, ErrorMessage = "o altura deve ser entre 0.1 a 999")]
        public float altura { get; set; }

        [Range(0.1, 999, ErrorMessage = "o largura deve ser entre 0.1 a 999")]
        public float largura { get; set; }

        [Range(0.1, 999, ErrorMessage = "o comprimento deve ser entre 0.1 a 999")]
        public float comprimento { get; set; }

        [Range(0.1 , 999, ErrorMessage = "o diametro deve ser entre 0.1 a 999")]
        public float diametro { get; set; }

        [StringLength(8, ErrorMessage = "O	tamanho	máximo	do	código	é	8	caracteres")]
        public string URL { get; set; }
    }
}