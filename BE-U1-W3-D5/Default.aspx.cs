using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace BE_U1_W3_D5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Verifica se la pagina è stata caricata per la prima volta
            if (!IsPostBack)
            {
                // Imposta la fonte dati per il repeater con la lista di fumetti e lo associa al repeater
                Repeater1.DataSource = Comics.GetList();
                Repeater1.DataBind();
            }
        }

        protected void AddCart_Click(object sender, EventArgs e)
        {
            // Ottiene il pulsante che ha generato l'evento
            Button button = (Button)sender;
            // Ottiene l'ID del fumetto da acquistare dal comando del pulsante
            int comicstobuy = Convert.ToInt32(button.CommandArgument);
            // Itera attraverso la lista di fumetti per trovare il fumetto corrispondente all'ID
            foreach (Comics comic in Comics.GetList())
            {
                if (comic.IdComics == comicstobuy)
                {
                    // Crea una nuova istanza del fumetto da aggiungere al carrello
                    Comics comicsInCart = new Comics
                    {
                        IdComics = comic.IdComics,
                        TitleComics = comic.TitleComics,
                        PriceComics = comic.PriceComics,
                        DescriptionComics = comic.DescriptionComics,
                        ImageComics = comic.ImageComics
                    };
                    // Aggiunge il fumetto al carrello
                    Comics.Cart.Add(comicsInCart);
                    break;
                }
            }
        }

        protected void GoToCart_Click(object sender, EventArgs e)
        {
            // Reindirizza l'utente alla pagina del carrello
            Response.Redirect("./Cart.aspx");
        }
    }
}

// Classe che rappresenta un fumetto
public class Comics
{
    public int IdComics { get; set; }
    public string TitleComics { get; set; }
    public decimal PriceComics { get; set; }
    public string ImageComics { get; set; }
    public string DescriptionComics { get; set; }
    public static List<Comics> Cart = new List<Comics>();
    public static List<Comics> GetList()
    {

        List<Comics> ComicsList = new List<Comics>();
        Comics c1 = new Comics { IdComics = 1, TitleComics = "Spiderman", PriceComics = 2.99m, DescriptionComics = "Un ragazzo morso da un ragno radioattivo", ImageComics = "https://www.lafeltrinelli.it/images/9788891233776_0_424_0_75.jpg" };
        Comics c2 = new Comics { IdComics = 2, TitleComics = "Batman", PriceComics = 3.99m, DescriptionComics = "Un miliardario che combatte il crimine", ImageComics = "https://www.ibs.it/images/9788828730415_0_536_0_75.jpg" };
        Comics c3 = new Comics { IdComics = 3, TitleComics = "Wolverine", PriceComics = 4.99m, DescriptionComics = "Un essere immortale tormentato dal suo passato", ImageComics = "https://www.ibs.it/images/9788891276223_0_536_0_75.jpg" };
        Comics c4 = new Comics { IdComics = 4, TitleComics = "Wonder Woman", PriceComics = 2.99m, DescriptionComics = "Una principessa amazzone con poteri divini", ImageComics = "https://www.ibs.it/images/9788828730811_0_150_0_75.jpg" };
        Comics c5 = new Comics { IdComics = 5, TitleComics = "Hulk", PriceComics = 3.99m, DescriptionComics = "Un uomo che si trasforma in un mostro verde", ImageComics = "https://www.ibs.it/images/9788828712190_0_150_0_75.jpg" };
        Comics c6 = new Comics { IdComics = 6, TitleComics = "Watchmen", PriceComics = 4.99m, DescriptionComics = "", ImageComics = "https://www.ibs.it/images/9788828717270_0_150_0_75.jpg" };
        Comics c7 = new Comics { IdComics = 7, TitleComics = "Captain America", PriceComics = 2.99m, DescriptionComics = "Un soldato con uno scudo indestructibile", ImageComics = "https://www.ibs.it/images/9788891232656_0_150_0_75.jpg" };
        Comics c8 = new Comics { IdComics = 8, TitleComics = "Thor", PriceComics = 3.99m, DescriptionComics = "Un dio del tuono con un martello magico", ImageComics = "https://www.ibs.it/images/5000000243417_0_0_150_0_75.jpg" };
        Comics c9 = new Comics { IdComics = 9, TitleComics = "Black Widow", PriceComics = 4.99m, DescriptionComics = "Una spia addestrata e combattente esperta", ImageComics = "https://books.google.it/books/publisher/content?id=tBgtEAAAQBAJ&hl=it&pg=PP1&img=1&zoom=3&bul=1&sig=ACfU3U1rfZ2yMSIThT-EGMaulF3gWsPEgA&w=1280" };
        Comics c10 = new Comics { IdComics = 10, TitleComics = "Deadpool", PriceComics = 2.99m, DescriptionComics = "Un mercenario con un senso dell'umorismo nero", ImageComics = "https://www.ibs.it/images/2570210139626_0_536_0_75.jpg" };

        ComicsList.Add(c1);
        ComicsList.Add(c2);
        ComicsList.Add(c3);
        ComicsList.Add(c4);
        ComicsList.Add(c5);
        ComicsList.Add(c6);
        ComicsList.Add(c7);
        ComicsList.Add(c8);
        ComicsList.Add(c9);
        ComicsList.Add(c10);

        return ComicsList;
    }
}