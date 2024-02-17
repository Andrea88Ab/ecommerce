<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="Ecommerce.Carrello" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Il tuo Carrello</title>
    
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
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
    </form>
</body>
</html>
