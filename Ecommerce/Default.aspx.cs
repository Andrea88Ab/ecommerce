using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Ecommerce
{
    public partial class Default : System.Web.UI.Page
    {
        public static List<Articolo> articoli = new List<Articolo>
    {
        
        new Articolo { Id = 1, Nome = "Laptop Gaming", Prezzo = 999.99m, Descrizione = "Laptop gaming ad alte prestazioni", ImmagineUrl = "url_immagine_laptop.jpg" },
        new Articolo { Id = 2, Nome = "Mouse Wireless", Prezzo = 49.99m, Descrizione = "Mouse wireless di precisione", ImmagineUrl = "url_immagine_mouse.jpg" },
        new Articolo { Id = 3, Nome = "Tastiera Meccanica", Prezzo = 89.99m, Descrizione = "Tastiera meccanica retroilluminata", ImmagineUrl = "url_immagine_tastiera.jpg" },
        new Articolo { Id = 4, Nome = "Monitor 4K", Prezzo = 399.99m, Descrizione = "Monitor 4K UHD 27 pollici", ImmagineUrl = "url_immagine_monitor.jpg" },
        new Articolo { Id = 5, Nome = "Scheda Grafica RTX 3080", Prezzo = 699.99m, Descrizione = "Scheda grafica NVIDIA RTX 3080", ImmagineUrl = "url_immagine_schedagrafica.jpg" },
        new Articolo { Id = 6, Nome = "Cuffie Bluetooth", Prezzo = 59.99m, Descrizione = "Cuffie Bluetooth con cancellazione del rumore", ImmagineUrl = "url_immagine_cuffie.jpg" },
        new Articolo { Id = 7, Nome = "Webcam HD", Prezzo = 79.99m, Descrizione = "Webcam HD con microfono integrato", ImmagineUrl = "url_immagine_webcam.jpg" },
        new Articolo { Id = 8, Nome = "Hard Disk Esterno", Prezzo = 99.99m, Descrizione = "Hard disk esterno USB 3.0 da 2TB", ImmagineUrl = "url_immagine_harddisk.jpg" },
        new Articolo { Id = 9, Nome = "Router Wi-Fi 6", Prezzo = 129.99m, Descrizione = "Router Wi-Fi 6 con supporto mesh", ImmagineUrl = "url_immagine_router.jpg" },
        new Articolo { Id = 10, Nome = "Sedia da Gaming", Prezzo = 199.99m, Descrizione = "Sedia da gaming ergonomica", ImmagineUrl = "url_immagine_sedia.jpg" }
    };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RepeaterArticoli.DataSource = articoli;
                RepeaterArticoli.DataBind();
            }
        }

        protected Articolo GetArticoloById(int id)
        {
            return articoli.FirstOrDefault(a => a.Id == id);
        }

        protected void ButtonAddToCart_Command(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int articoloId = Convert.ToInt32(button.CommandArgument);

            List<Articolo> carrello;
            if (Session["Carrello"] == null)
            {
                carrello = new List<Articolo>();
            }
            else
            {
                carrello = (List<Articolo>)Session["Carrello"];
            }

            Articolo articoloAggiunto = GetArticoloById(articoloId);
            if (articoloAggiunto != null)
            {
                carrello.Add(articoloAggiunto);
            }

            Session["Carrello"] = carrello;
        }
    }

}
