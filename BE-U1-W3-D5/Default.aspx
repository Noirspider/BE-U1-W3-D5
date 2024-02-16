<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BE_U1_W3_D5.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
        <link href="StyleSheet1.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Repeater ID="Repeater1" runat="server" ItemType="Comics">
    <ItemTemplate>
        <div class="col-md-4 card-body">
            <div class="card col-md-4 mx-2 my-2">
                <!-- This line displays an image within a card in the Repeater control. -->
                <img class="card-img-top mt-2" src="<%# Item.ImageComics %>" alt="Card image cap">
                <div class="card-body">
                    <h4 class="card-title"><%# Item.TitleComics %></h4>
                    <p class="card-text"><%# Item.DescriptionComics %></p>
                    <p class="card-text"><%# Item.PriceComics %></p>
                    <div class="d-flex justify-content-between align-items-center">
                        <div class="btn-group">
                            <a href="details.aspx?idcomics=<%# Item.IdComics %>">Dettagli</a>
                            <asp:Button type="button" ID="AddCart" CommandArgument="<%# Item.IdComics %>" CssClass="btn btn-sm btn-outline-secondary" runat="server" Text="Acquista" OnClick="AddCart_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </ItemTemplate>
</asp:Repeater>

<a href="cart.aspx" class="btn btn-danger">Vai al carrello</a >
</asp:Content>