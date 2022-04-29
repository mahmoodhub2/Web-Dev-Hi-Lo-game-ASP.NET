<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page4.aspx.cs" Inherits="Hilo_ASP_2.Page4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:green;">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="wonL" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Play Again" OnClick="Button1_Click" />
            <asp:TextBox ID="NameBox" visible="false" runat="server"> </asp:TextBox> 

        </div>
    </form>
</body>
</html>
