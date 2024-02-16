using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static BE_U1_W3_D5.Default;

namespace BE_U1_W3_D5
{
    public partial class details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string idQuery = Request.QueryString["idComics"];
            foreach (Comics comic in Comics.GetList())
            {
                if (comic.IdComics.ToString() == idQuery)
                {
                    Image1.ImageUrl = comic.ImageComics;
                    LabelTitle.Text = comic.TitleComics;
                    LabelPrice.Text = comic.PriceComics.ToString("c2");
                    LabelDescription.Text = comic.DescriptionComics;
                }
            }
        }
    }
}
