using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Carrello : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CaricaCarrello();
            }
        }

        private void CaricaCarrello()
        {
            if (Session["Carrello"] != null)
            {
                List<Articolo> carrello = (List<Articolo>)Session["Carrello"];
                GridViewCarrello.DataSource = carrello;
                GridViewCarrello.DataBind();
            }
        }

        protected void ButtonRimuovi_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int articoloId = Convert.ToInt32(button.CommandArgument);
            List<Articolo> carrello = (List<Articolo>)Session["Carrello"];

            Articolo articoloDaRimuovere = carrello.FirstOrDefault(a => a.Id == articoloId);
            if (articoloDaRimuovere != null)
            {
                carrello.Remove(articoloDaRimuovere);
                Session["Carrello"] = carrello;
                CaricaCarrello(); // Aggiorna la visualizzazione del carrello
            }
        }
    }
}
