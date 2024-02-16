using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace BE_U1_W3_D5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Repeater1.DataSource = Comics.GetList();
                Repeater1.DataBind();
            }
        }

        protected void AddCart_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int comicstobuy = Convert.ToInt32(button.CommandArgument);
            foreach (Comics comic in Comics.GetList())
            {
                if (comic.IdComics == comicstobuy)
                {
                    Comics comicsInCart = new Comics
                    {
                        IdComics = comic.IdComics,
                        TitleComics = comic.TitleComics,
                        PriceComics = comic.PriceComics,
                        DescriptionComics = comic.DescriptionComics,
                        ImageComics = comic.ImageComics
                    };
                    Comics.Cart.Add(comicsInCart);
                    break;
                }
            }
        }

        protected void GoToCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Cart.aspx");
        }
    }
}
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
        Comics c2 = new Comics { IdComics = 2, TitleComics = "Batman", PriceComics = 3.99m, DescriptionComics = "Un miliardario che combatte il crimine", ImageComics = "https://www.lafeltrinelli.it/images/9788891233776_0_424_0_75.jpg" };
        Comics c3 = new Comics { IdComics = 3, TitleComics = "Superman", PriceComics = 4.99m, DescriptionComics = "Un alieno con superpoteri", ImageComics = "https://www.lafeltrinelli.it/images/9788891233776_0_424_0_75.jpg" };
        Comics c4 = new Comics { IdComics = 4, TitleComics = "Wonder Woman", PriceComics = 2.99m, DescriptionComics = "Una principessa amazzone con poteri divini", ImageComics = "https://www.lafeltrinelli.it/images/9788891233776_0_424_0_75.jpg" };
        Comics c5 = new Comics { IdComics = 5, TitleComics = "Hulk", PriceComics = 3.99m, DescriptionComics = "Un uomo che si trasforma in un mostro verde", ImageComics = "https://www.lafeltrinelli.it/images/9788891233776_0_424_0_75.jpg" };
        Comics c6 = new Comics { IdComics = 6, TitleComics = "Iron Man", PriceComics = 4.99m, DescriptionComics = "Un genio miliardario con un'armatura tecnologica", ImageComics = "https://www.lafeltrinelli.it/images/9788891233776_0_424_0_75.jpg" };
        Comics c7 = new Comics { IdComics = 7, TitleComics = "Captain America", PriceComics = 2.99m, DescriptionComics = "Un soldato con uno scudo indestructibile", ImageComics = "ahttps://www.lafeltrinelli.it/images/9788891233776_0_424_0_75.jpgdd" };
        Comics c8 = new Comics { IdComics = 8, TitleComics = "Thor", PriceComics = 3.99m, DescriptionComics = "Un dio del tuono con un martello magico", ImageComics = "https://www.lafeltrinelli.it/images/9788891233776_0_424_0_75.jpg" };
        Comics c9 = new Comics { IdComics = 9, TitleComics = "Black Widow", PriceComics = 4.99m, DescriptionComics = "Una spia addestrata e combattente esperta", ImageComics = "https://www.lafeltrinelli.it/images/9788891233776_0_424_0_75.jpg" };
        Comics c10 = new Comics { IdComics = 10, TitleComics = "Deadpool", PriceComics = 2.99m, DescriptionComics = "Un mercenario con un senso dell'umorismo nero", ImageComics = "https://www.lafeltrinelli.it/images/9788891233776_0_424_0_75.jpg" };

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