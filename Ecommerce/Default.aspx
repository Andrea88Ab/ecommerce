<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ecommerce.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Articoli Informatici</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="row">
                <asp:Repeater ID="RepeaterArticoli" runat="server">
                    <ItemTemplate>
                        <div class="col-md-4 mb-4">
                            <div class="card mx-auto" style="width: 18rem;">
                                <img class="card-img-top" src='<%# Eval("ImmagineUrl") %>' alt="Card image cap">
                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval("Nome") %></h5>
                                    <p class="card-text"><%# Eval("Descrizione") %></p>
                                    <a href="Dettaglio.aspx?id=<%# Eval("Id") %>" class="btn btn-primary">Dettagli</a>
                                    <asp:Button ID="ButtonAddToCart" runat="server" Text="Aggiungi al carrello" CommandArgument='<%# Eval("Id") %>' OnCommand="ButtonAddToCart_Command" CssClass="btn btn-success"/>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </form>
</body>
</html>