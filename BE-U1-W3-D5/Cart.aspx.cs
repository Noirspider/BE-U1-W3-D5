using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static BE_U1_W3_D5.Default;

namespace BE_U1_W3_D5
{
    public partial class Cart : System.Web.UI.Page
    {
        // Metodo chiamato quando la pagina viene caricata
        protected void Page_Load(object sender, EventArgs e)
        {
            // Carica il carrello solo se la pagina non è in postback
            if (!IsPostBack)
            {
                LoadCart();
            }
        }

        // Gestore dell'evento per il pulsante "Svuota Carrello"
        protected void EmptyCart_Click(object sender, EventArgs e)
        {
            // Svuota il carrello e ricarica la pagina
            Comics.Cart.Clear();
            LoadCart();
        }

        // Metodo per caricare il carrello nella Repeater e calcolare il totale
        private void LoadCart()
        {
            Repeater1.DataSource = Comics.Cart;
            Repeater1.DataBind();
            decimal total = CalculateTotal();
            LabelTotale.Text = "Totale: " + total.ToString("c2");
        }

        // Metodo per calcolare il totale del carrello
        private decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (Comics comic in Comics.Cart)
            {
                total += Convert.ToDecimal(comic.PriceComics);
            }
            return total;
        }
    }
}
