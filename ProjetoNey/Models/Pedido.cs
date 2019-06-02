using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace ProjetoNey.Models
{
    public class Pedido
    {

        public Pedido()
        {
            this.items = new HashSet<Item>();
        }

        public int Id { get; set; }
        [Required] public string EmailUser { get; set; }

        public DateTime dataPedido { get; set; }

        public DateTime  dataEntrega { get; set; }

         public string status { get; set; } //Colocar tipos novo, fechado, cancelado, entregue

        public decimal precoTotalPedido { get; set; }

        public float pesoTotalPedido { get; set; }

        public float precoFrete { get; set; }

        public virtual ICollection<Item> items { get; set; }
    }
}