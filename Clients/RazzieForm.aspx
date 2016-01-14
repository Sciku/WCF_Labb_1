<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RazzieForm.aspx.cs" Inherits="Clients.RazzieForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Razzies för sämsta film</h1>
    <div>
        <asp:TextBox ID="TextBox1" runat="server" placeholder="Skriv in ett årtal"></asp:TextBox>
    </div>
        <p>
        <asp:Button ID="Button1" runat="server" Text="Klicka här!" OnClick="Button1_Click" />
        </p>
        <p>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
