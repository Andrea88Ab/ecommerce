<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Ecommerce.Home" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Elenco Articoli</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet"/>
</head>
<body>
    <div class="container mt-4">
        
        <form id="form1" runat="server">
            <asp:Repeater ID="RepeaterArticoli" runat="server" OnItemCommand="RepeaterArticoli_ItemCommand">
                <ItemTemplate>
                    <div class="card" style="width: 18rem; float: left; margin: 10px;">
                        <img class="card-img-top" src='<%# Eval("ImmagineUrl") %>' alt="Immagine Articolo">
                        <div class="card-body">
                            <h5 class="card-title"><%# Eval("Nome") %></h5>
                            <p class="card-text"><%# Eval("Descrizione") %></p>
                            <p class="card-text">Prezzo: <%# Eval("Prezzo", "{0:C}") %></p>
                            <a href="DettaglioArticolo.aspx?Id=<%# Eval("Id") %>" class="btn btn-primary">Visualizza Dettaglio</a>
                            
                            <asp:LinkButton ID="LinkButtonAddToCart" runat="server" CommandName="AddToCart" CommandArgument='<%# Eval("Id") %>' CssClass="btn btn-success">Aggiungi al Carrello</asp:LinkButton>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </form>
    </div>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.bundle.min.js"></script>
</body>
</html>
