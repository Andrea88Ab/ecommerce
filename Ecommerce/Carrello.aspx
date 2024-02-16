

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="Ecommerce.Carrello" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Il tuo Carrello</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"/>
</head>
<body>
    <div class="container mt-4">
        <h2>Carrello</h2>
        
        <asp:GridView ID="GridViewCarrello" runat="server" CssClass="table table-bordered" AutoGenerateColumns="False" OnRowDeleting="GridViewCarrello_RowDeleting" DataKeyNames="Id">
    


            <Columns>
                <asp:BoundField DataField="Nome" HeaderText="Nome" />
                <asp:BoundField DataField="Prezzo" HeaderText="Prezzo" DataFormatString="{0:C}" />
                <asp:BoundField DataField="Quantita" HeaderText="Quantità" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="ButtonRimuovi" CommandArgument='<%# Eval("Id") %>' runat="server" Text="Rimuovi" CssClass="btn btn-danger" OnClick="ButtonRimuovi_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Label ID="LabelTotale" runat="server" CssClass="h4"></asp:Label>
        <asp:Button ID="ButtonSvuota" runat="server" Text="Svuota Carrello" OnClick="ButtonSvuota_Click" CssClass="btn btn-warning" />
    </div>
    
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.bundle.min.js"></script>
</body>
</html>

