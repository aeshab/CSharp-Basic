<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication8.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1
        {
            height: 157px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:TextBox ID="txtA" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="regEx" runat="server" 
        ErrorMessage="RegularExpressionValidator" ControlToValidate="txtA" 
        ValidationExpression="^[0-9]+"></asp:RegularExpressionValidator>
    <asp:RequiredFieldValidator ID="rfv1" runat="server" 
        ErrorMessage="RequiredFieldValidator" ControlToValidate="txtA"></asp:RequiredFieldValidator>
    <div>
    
        <asp:TextBox ID="txtB" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfv2" runat="server" 
            ErrorMessage="RequiredFieldValidator" ControlToValidate="txtB"></asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="btnAdd" runat="server" onclick="btnAdd_Click" Text="Addition" />
        <asp:Button ID="btnSub" runat="server" onclick="btnSub_Click" 
            Text="Subtraction" />
        <br />
        <asp:Button ID="btnMul" runat="server" Text="Multiplication" 
            onclick="btnMul_Click" />
        <asp:Button ID="btnDiv" runat="server" Text="Division" onclick="btnDiv_Click" 
            style="height: 26px" />
        <br />
        <asp:Label ID="lblRes" runat="server" Text="Result"></asp:Label>
    
    </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
