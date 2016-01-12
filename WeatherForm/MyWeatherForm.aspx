<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyWeatherForm.aspx.cs" Inherits="WeatherForm.MyWeatherForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="***VÄDERKNAPP***" />
        <br/>
        <asp:Label ID="Label1" runat="server" Text="Vädret visas här om du trycker på knappen :)"></asp:Label>
    
    </div>
    </form>
</body>
</html>
