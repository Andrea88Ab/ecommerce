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
            <h1 class="text-center" style="color: red; font-size: 60px; font-weight: bold;">Game Pro</h1>


            <!-- Il resto del tuo contenuto va qui -->
        </div>
       
 
        <div class="container mt-5">
    <div class="row mb-4">
        <div class="col-12 text-right">
            <a href="Carrello.aspx" class="btn btn-info">Vai al Carrello</a>
        </div>
    </div>
        <div class="container mt-5">
            <div class="row">
                <asp:Repeater ID="RepeaterArticoli" runat="server">
                    <ItemTemplate>
                        <div class="col-md-4 mb-4">
                            <div class="card mx-auto" style="width: 18rem;">
                                <asp:Image ID="ImageArticolo" runat="server" ImageUrl='<%# Eval("ImmagineUrl").ToString() %>' CssClass="card-img-top" AltText="Immagine Articolo" Width="100%" Height="200px" />

                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval("Nome") %></h5>
                                    <p class="card-text"><%# Eval("Descrizione") %></p>
                                    <a href="Dettaglio.aspx?id=<%# Eval("Id") %>" class="btn btn-primary d-block mx-auto">Dettagli</a>

                                   <asp:Button ID="ButtonAddToCart" runat="server" Text="Aggiungi al carrello" CommandArgument='<%# Eval("Id") %>' OnCommand="ButtonAddToCart_Command" CssClass="btn btn-success mt-3 d-block mx-auto"/>
                                    


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