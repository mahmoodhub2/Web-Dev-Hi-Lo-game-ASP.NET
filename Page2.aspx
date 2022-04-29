<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="Hilo_ASP_2.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            padding: 20px;
            background-color: rebeccapurple;
        }
        table#inputTable th {
            background-color: black;
            color: white;
        }
        .wlecomS {
            font-family: 'Serif ';
            font-size: 12px;
            color: deepskyblue
        }
        .td {
            color: deepskyblue
        }
        .input {
            font-family: Courier;
            font-size: 13px;
        }
        form {
            text-align: center;
        }
        .button{
            align-center;
        }
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <asp:Label CssClass="wlecomS" ID="welcome" runat="server" ></asp:Label>
            <br />
            <asp:Label CssClass="wlecomS" ID="Label1" runat="server" >What is the maximum guess value?</asp:Label>

            <asp:TextBox CssClass="input" ID="MaxRange" runat="server"></asp:TextBox>
            
            <asp:TextBox CssClass="input" ID="carrier" runat="server" Visible="False"></asp:TextBox>
            
            <asp:HiddenField ID="nameHolder" runat="server" />

            <asp:Label CssClass="wlecomS" ID="MaxErr" BackColor="Red" runat="server" Text=""></asp:Label>
             <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate ="MaxRange" runat="server" ErrorMessage="This Filed Shouldn't be empty"></asp:RequiredFieldValidator>

            <br />
            <asp:Button ID="RangeButton" runat="server" Text="Enter Range" OnClick="RangeButton_Click" />
            
            
        </div>
    </form>
</body>
</html>
