<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NameDayForm.aspx.cs" Inherits="Clients.NameDayForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Namnsdags kalkylatorn v2000.16</h1>
    <div>
        <asp:TextBox ID="TextBox1" runat="server" placeholder="Skriv in namn, få datum"></asp:TextBox>
    </div>
        <p>
        <asp:Button ID="Button1" runat="server" Text="Klicka här för datum!" OnClick="Button1_Click" />
        </p>
        <p>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
