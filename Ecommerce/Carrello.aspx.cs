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

                // Aggiorna il totale articoli nel carrello
                LabelTotaleArticoli.Text = carrello.Count.ToString();

                // Opzionale: Calcola e mostra il prezzo totale degli articoli nel carrello
                decimal totalePrezzo = carrello.Sum(articolo => articolo.Prezzo);
                LabelTotalePrezzo.Text = $"Totale: {totalePrezzo:C}";

                ButtonSvuotaCarrello.Enabled = carrello.Any();
            }
            else
            {
                LabelTotaleArticoli.Text = "0";
                // Opzionale: Aggiorna il Label del prezzo totale se presente
                LabelTotalePrezzo.Text = "Totale: €0,00";
                ButtonSvuotaCarrello.Enabled = false;
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

        protected void ButtonSvuotaCarrello_Click(object sender, EventArgs e)
        {
            if (Session["Carrello"] != null)
            {
                List<Articolo> carrello = (List<Articolo>)Session["Carrello"];
                carrello.Clear(); // Rimuove tutti gli articoli
                Session["Carrello"] = carrello;
                CaricaCarrello(); // Aggiorna la visualizzazione
            }
        }
    }
}
