using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class CarrelloItem
    {
        public int Id { get; set; } 
        public string Nome { get; set; }
        public decimal Prezzo { get; set; }
        public int Quantita { get; set; } = 1;
    }



}