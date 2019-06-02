using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;


namespace ProjetoNey.Models
{
    public class Item
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Range(1, 999, ErrorMessage = "A quantidade varia de 	1	e	999.")]
        public uint quantidade { get; set; }

        [Required]
        [Range(1, 999999, ErrorMessage = "O  ID do produto varia de 	1	e	999999.")]
        public int ProdutoID { get; set; }

        [Required]
        [Range(1, 999, ErrorMessage = "A quantidade varia de 	1	e	9999.")]
        public virtual Produto Product { get; set; }

        [Required]
        [Range(1, 999999, ErrorMessage = "O  ID da ordem do pedido varia de 	1	e	999999.")]
        public int OrderId { get; set; }

    }
}