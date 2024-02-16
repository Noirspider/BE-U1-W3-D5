using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static BE_U1_W3_D5.Default; // Importa lo spazio dei nomi statico da Default

namespace BE_U1_W3_D5
{
    public partial class details : System.Web.UI.Page
    {
        // Metodo chiamato quando la pagina viene caricata
        protected void Page_Load(object sender, EventArgs e)
        {
            // Ottiene l'ID del fumetto dalla stringa di query nell'URL
            string idQuery = Request.QueryString["idComics"];

            // Itera attraverso la lista di fumetti per trovare quello con l'ID corrispondente
            foreach (Comics comic in Comics.GetList())
            {
                if (comic.IdComics.ToString() == idQuery)
                {
                    // Aggiorna l'immagine, il titolo, il prezzo e la descrizione del fumetto nei controlli della pagina
                    Image1.ImageUrl = comic.ImageComics;
                    LabelTitle.Text = comic.TitleComics;
                    LabelPrice.Text = comic.PriceComics.ToString("c2");
                    LabelDescription.Text = comic.DescriptionComics;
                }
            }
        }
    }
}
