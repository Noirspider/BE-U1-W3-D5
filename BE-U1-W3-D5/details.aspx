<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="details.aspx.cs" Inherits="BE_U1_W3_D5.details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Collegamento al foglio di stile details.css -->
    <link href="details.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Div per la visualizzazione dei dettagli -->
      
     

    <div class="row">
        <!-- Immagine del fumetto (colonna media su dispositivi di larghezza media) -->
        <asp:Image CssClass="col col-md-6" ID="Image1" runat="server" />
        <!-- Div per i dettagli del fumetto (colonna media su dispositivi di larghezza media) -->
        <div class="col col-md-6 pt-5">
            <!-- Titolo del fumetto -->
            <h1><asp:Label ID="LabelTitle" runat="server" Text=""></asp:Label></h1>
            <!-- Descrizione del fumetto -->
            <h3><asp:Label ID="LabelDescription" runat="server" Text=""></asp:Label></h3>
            <!-- Prezzo del fumetto -->
            <asp:Label ID="LabelPrice" runat="server" Text=""></asp:Label>
           
        </div>
        <a href="default.aspx" class="btn btn-primary btn-home">Torna alla home</a>
    </div>
  

</asp:Content>
