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
                
                if (Request.QueryString["id"] != null)
                {
                    int articoloId = Convert.ToInt32(Request.QueryString["id"]);
                    MostraDettagliArticolo(articoloId);
                }
                else
                {
                    
                    Response.Redirect("Default.aspx");
                }
            }
        }

        private void MostraDettagliArticolo(int id)
        {
            
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
