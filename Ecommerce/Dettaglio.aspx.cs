using Ecommerce.Models;
using System;
using System.Linq;

namespace Ecommerce
{
    public partial class Dettaglio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Assicurati che l'ID sia stato fornito
                if (Request.QueryString["id"] != null)
                {
                    int articoloId = Convert.ToInt32(Request.QueryString["id"]);
                    MostraDettagliArticolo(articoloId);
                }
                else
                {
                    // Gestisci il caso in cui l'ID non è fornito
                    Response.Redirect("Default.aspx");
                }
            }
        }

        private void MostraDettagliArticolo(int id)
        {
            // Utilizza la lista di articoli dalla tua classe Default o una fonte di dati
            Articolo articolo = Default.articoli.FirstOrDefault(a => a.Id == id);

            if (articolo != null)
            {
                imgArticolo.Src = articolo.ImmagineUrl;
                lblNome.InnerText = articolo.Nome;
                lblDescrizione.InnerText = articolo.Descrizione;
                lblPrezzo.InnerText = $"{articolo.Prezzo:C}";
            }
        }
    }
}
