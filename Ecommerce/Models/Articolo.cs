using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    [Serializable]
    public class Articolo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public string ImmagineUrl { get; set; }
    }


}