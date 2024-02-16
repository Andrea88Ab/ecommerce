using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Articolo> articoli = new List<Articolo>
        {
            new Articolo { Id = 1, Nome = "Smartphone", Descrizione = "Smartphone di ultima generazione", Prezzo = 999.99m, ImmagineUrl = "https://imgbb.com/][img]https://i.ibb.co/YRqxsGR/download.jpg[/img][/url"},
            new Articolo { Id = 2, Nome = "Laptop", Descrizione = "Laptop leggero e potente", Prezzo = 1299.99m, ImmagineUrl = "link/to/laptop.jpg" },
            new Articolo { Id = 3, Nome = "Tablet", Descrizione = "Perfetto per il lavoro e il gioco", Prezzo = 499.99m, ImmagineUrl = "link/to/tablet.jpg" },
            new Articolo { Id = 4, Nome = "Smartwatch", Descrizione = "Tieni traccia della tua attività", Prezzo = 199.99m, ImmagineUrl = "link/to/smartwatch.jpg" },
            new Articolo { Id = 5, Nome = "Cuffie Bluetooth", Descrizione = "Audio di alta qualità", Prezzo = 149.99m, ImmagineUrl = "link/to/cuffie.jpg" },
            new Articolo { Id = 6, Nome = "Fotocamera Mirrorless", Descrizione = "Cattura i tuoi momenti", Prezzo = 899.99m, ImmagineUrl = "link/to/fotocamera.jpg" },
            new Articolo { Id = 7, Nome = "Videogioco", Descrizione = "Il videogioco del momento", Prezzo = 59.99m, ImmagineUrl = "link/to/videogioco.jpg" },
            new Articolo { Id = 8, Nome = "Libro", Descrizione = "L'ultimo bestseller", Prezzo = 19.99m, ImmagineUrl = "link/to/libro.jpg" },
            new Articolo { Id = 9, Nome = "Tastiera Meccanica", Descrizione = "Per gli appassionati di gaming e digitazione", Prezzo = 99.99m, ImmagineUrl = "link/to/tastiera.jpg" },
            new Articolo { Id = 10, Nome = "Mouse Gaming", Descrizione = "Precisione e velocità", Prezzo = 49.99m, ImmagineUrl = "link/to/mouse.jpg" }
        };


                RepeaterArticoli.DataSource = articoli;
                RepeaterArticoli.DataBind();
            }


        }
        protected void RepeaterArticoli_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "AddToCart")
            {
                int articoloId = Convert.ToInt32(e.CommandArgument);

                
                Articolo articolo = OttieniArticoloDaId(articoloId);

                
                List<CarrelloItem> carrello = Session["Carrello"] as List<CarrelloItem> ?? new List<CarrelloItem>();

                
                CarrelloItem item = carrello.Find(i => i.Id == articoloId);
                if (item != null)
                {
                    
                    item.Quantita += 1;
                }
                else
                {
                    
                    carrello.Add(new CarrelloItem { Id = articolo.Id, Nome = articolo.Nome, Prezzo = articolo.Prezzo, Quantita = 1 });
                }

                
                Session["Carrello"] = carrello;

                
                Response.Redirect("Carrello.aspx"); 
            }
        }

        private Articolo OttieniArticoloDaId(int id)
        {
        
            return new Articolo { Id = id, Nome = "Articolo " + id, Prezzo = 100m * id, Descrizione = "Descrizione per Articolo " + id, ImmagineUrl = "/path/to/image" + id + ".jpg" };
        }



    }


    }

