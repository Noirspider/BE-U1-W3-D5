<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="BE_U1_W3_D5.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Cart.css" rel="stylesheet"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Repeater ID="Repeater1" runat="server" ItemType="Comics">
     <ItemTemplate>
     <div class="card mb-3" style="max-width: 540px;">
         <div class="row no-gutters">
             <div class="col-md-4 my-2">
                 <img src="<%#Item.ImageComics %>" class="card-img" alt="...">
                                 </div>
                <div class="col-md-8">
                    <div class="card-body">
                        <h5 class="card-title"><%#Item.TitleComics %></h5>
                        <p class="card-text"><small class="text-muted"><%#Item.PriceComics.ToString("c2") %></small></p>
                    </div>
                </div>
            </div>
        </div>

    </ItemTemplate>
</asp:Repeater>
      <h3 style="text-align:center"><asp:Label ID="LabelTotale" runat="server" Text=""></asp:Label></h3>
  <asp:Button ID="EmptyCart" CssClass="btn btn-warning" runat="server" Text="Svuota Carrello"  OnClick="EmptyCart_Click"/>
</asp:Content>
