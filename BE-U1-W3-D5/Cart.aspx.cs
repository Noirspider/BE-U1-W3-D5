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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCart();
            }
        }

        protected void EmptyCart_Click(object sender, EventArgs e)
        {
            Comics.Cart.Clear();
            LoadCart();
        }

        private void LoadCart()
        {
            Repeater1.DataSource = Comics.Cart;
            Repeater1.DataBind();
            decimal total = CalculateTotal();
            LabelTotale.Text = "Totale: " + total.ToString("c2");
        }

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
