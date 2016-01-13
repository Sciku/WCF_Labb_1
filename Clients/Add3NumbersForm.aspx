<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add3NumbersForm.aspx.cs" Inherits="Clients.Add3NumbersForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 153px">
    <form id="form1" runat="server">
        <h1>THE BEST CALCULATOR IN THE UNIVERSE!!!</h1>
    <div>   
        <asp:TextBox ID="TextBox1" runat="server" placeholder="Skriv in första talet"></asp:TextBox> + 
        <asp:TextBox ID="TextBox2" runat="server" placeholder="Skriv in andra talet"></asp:TextBox> +
        <asp:TextBox ID="TextBox3" runat="server" placeholder="Skriv in tredje talet"></asp:TextBox> =
         
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        <br />
        <br />

    
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Räkna ut" Width="119px" />
        
    </form>
</body>
</html>
