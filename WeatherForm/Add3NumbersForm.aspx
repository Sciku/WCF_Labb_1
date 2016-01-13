<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add3NumbersForm.aspx.cs" Inherits="WeatherForm.Add3NumbersForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 153px">
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

    
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Räkna ut" Width="119px" />
        <p>
            <asp:Label ID="Label1" runat="server" Text="Här kommer resultatet visas =)"></asp:Label>
        </p>
    </form>
</body>
</html>
