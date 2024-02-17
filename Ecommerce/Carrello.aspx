<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="Ecommerce.Carrello" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Il tuo Carrello</title>
    
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <h1 class="text-center" style= "font-size: 60px; font-weight: bold;">Carrello</h1>

     
        <asp:GridView ID="GridViewCarrello" runat="server" CssClass="table table-hover" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                <asp:BoundField DataField="Descrizione" HeaderText="Descrizione" SortExpression="Descrizione" />
                <asp:BoundField DataField="Prezzo" HeaderText="Prezzo" SortExpression="Prezzo" HtmlEncode="False" DataFormatString="{0:C}" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="ButtonRimuovi" runat="server" CommandArgument='<%# Eval("Id") %>' Text="Rimuovi" OnClick="ButtonRimuovi_Click" CssClass="btn btn-danger" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <div class="mt-4 text-center">
            <asp:Button ID="ButtonSvuotaCarrello" runat="server" Text="Svuota Carrello" OnClick="ButtonSvuotaCarrello_Click" CssClass="btn btn-warning" />

        
  <div class="row justify-content-center">
    <div class="col-md-8">
        <div class="card text-center mt-3 mb-3">
            <div class="card-header">
                Riepilogo Carrello
            </div>
            <div class="card-body">
                <h5 class="card-title">Totale Articoli nel Carrello: <asp:Label ID="LabelTotaleArticoli" runat="server" Text="0"></asp:Label></h5>
                <p class="card-text"><asp:Label ID="LabelTotalePrezzo" runat="server" Text="€0,00"></asp:Label></p>
                <a href="Default.aspx" class="btn btn-primary">Continua lo Shopping</a>
            </div>
        </div>
    </div>
</div>

    </div>
    </form>
</body>
</html>
