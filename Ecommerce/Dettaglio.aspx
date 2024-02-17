<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dettaglio.aspx.cs" Inherits="Ecommerce.Dettaglio" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dettagli Articolo</title>
    
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-3">
            <h2>Dettagli Articolo</h2>
            <div class="card" style="width: 18rem;">
                <img id="imgArticolo" runat="server" class="card-img-top" alt="Immagine Articolo"/>
                <div class="card-body">
                    <h5 class="card-title" id="lblNome" runat="server"></h5>
                    <p class="card-text" id="lblDescrizione" runat="server"></p>
                    <p class="card-text"><strong>Prezzo:</strong> <span id="lblPrezzo" runat="server"></span></p>
                    <a href="Default.aspx" class="btn btn-primary">Torna agli acquisti</a>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

