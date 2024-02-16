<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="BE_U1_W3_D5.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Collegamento al foglio di stile Cart.css -->
    <link href="Cart.css" rel="stylesheet"/> 
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Repeater per visualizzare i fumetti nel carrello -->
    <asp:Repeater ID="Repeater1" runat="server" ItemType="Comics">
        <ItemTemplate>
            <!-- Inizio della card -->
            <div class="card mb-3" style="max-width: 540px;"> 
                <!-- Riga senza margini -->
                <div class="row"> 
                    <!-- Colonna di larghezza media (md) per l'immagine -->
                    <div class="col-md-4 my-2"> 
                        <!-- Immagine della card -->
                        <img src="<%#Item.ImageComics %>" class="card-img" alt="..."> 
                    </div>
                    <!-- Colonna di larghezza media (md) per il corpo della card -->
                    <div> 
                        <!-- Corpo della card -->
                        <div class="card-body"> 
                            <!-- Titolo della card -->
                            <h5 class="card-title"><%#Item.TitleComics %></h5> 
                            <!-- Testo della card con prezzo formattato come valuta -->
                            <p class="card-text"><small class="text-muted"><%#Item.PriceComics.ToString("c2") %></small></p> 
<!-- Pulsante per rimuovere il fumetto dal carrello -->
<asp:Button ID="RemoveFromCart" CssClass="btn btn-danger" CommandArgument="<%# Item.IdComics %>" runat="server" Text="Rimuovi dal Carrello"  OnClick="RemoveFromCart_Click"/>
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>

    <!-- Etichetta per visualizzare il totale -->
    <h3 style="text-align:center"><asp:Label ID="LabelTotale" runat="server" Text=""></asp:Label></h3> 
    <!-- Pulsante per svuotare il carrello -->
    <asp:Button ID="EmptyCart" CssClass="btn btn-warning" runat="server" Text="Svuota Carrello" OnClick="EmptyCart_Click"/> 
</asp:Content>
