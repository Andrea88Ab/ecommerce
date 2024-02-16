using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Carrello : System.Web.UI.Page
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
            List<CarrelloItem> carrello = Session["Carrello"] as List<CarrelloItem>;
            if (carrello == null)
            {
                carrello = new List<CarrelloItem>();
            }

            GridViewCarrello.DataSource = carrello;
            GridViewCarrello.DataBind();

            decimal totale = carrello.Sum(item => item.Prezzo * item.Quantita);
            LabelTotale.Text = "Totale: " + totale.ToString("C");
        }

        protected void GridViewCarrello_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int articoloId = Convert.ToInt32(GridViewCarrello.DataKeys[e.RowIndex].Value);
            List<CarrelloItem> carrello = Session["Carrello"] as List<CarrelloItem>;
            if (carrello != null)
            {
                CarrelloItem itemDaRimuovere = carrello.Find(item => item.Id == articoloId);
                if (itemDaRimuovere != null)
                {
                    carrello.Remove(itemDaRimuovere);
                    Session["Carrello"] = carrello;
                    CaricaCarrello(); 
                }
            }
        }

        protected void ButtonSvuota_Click(object sender, EventArgs e)
        {
            Session["Carrello"] = null; 
            CaricaCarrello();
        }

    }
}