<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DettaglioArticoloaspx.aspx.cs" Inherits="Ecommerce.DettaglioArticoloaspx" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dettaglio Articolo</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet"/>
</head>
<body>
    <div class="container mt-4">
        <form id="form1" runat="server">
            <asp:Image ID="imgArticolo" runat="server" CssClass="img-fluid" />
            <h2><asp:Label ID="lblNome" runat="server" Text=""></asp:Label></h2>
            <p><asp:Label ID="lblDescrizione" runat="server" Text=""></asp:Label></p>
            <p>Prezzo: <asp:Label ID="lblPrezzo" runat="server" Text=""></asp:Label></p>
        </form>
    </div>
</body>
</html>
