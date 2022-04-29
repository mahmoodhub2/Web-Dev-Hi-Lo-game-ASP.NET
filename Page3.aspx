<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page3.aspx.cs" Inherits="Hilo_ASP_2.Page3" %>

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
            <asp:Label CssClass="wlecomS" ID="StillWelcom" runat="server" ></asp:Label>
            <br />
            <asp:Label CssClass="wlecomS" ID="GuessL" runat="server">Enter your guess</asp:Label>
            
            <asp:TextBox CssClass="input" ID="Guess" runat="server"></asp:TextBox>
            
            <asp:TextBox CssClass="input" Visible="false" ID="carrier2" runat="server"></asp:TextBox>
            
            <asp:Label CssClass="wlecomS" ID="allowable" runat="server"></asp:Label>
            <br />
            <asp:Label CssClass="wlecomS" BackColor="Red" ID="GuessErr" runat="server" ></asp:Label>

            <asp:HiddenField ID="HiddenField1" runat="server" />
            <asp:HiddenField ID="HiddenField2" runat="server" />
            <br />
            <asp:RequiredFieldValidator ControlToValidate="Guess" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Shouldn't be empty"></asp:RequiredFieldValidator>
            <br />

            <br />
            <asp:Button ID="GuessButton" runat="server" Text="Make This Guess" OnClick="Guess_Click"/>
        </div>
    </form>
</body>
</html>
