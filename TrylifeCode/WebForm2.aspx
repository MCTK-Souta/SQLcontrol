﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="TrylifeCode.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<%--        <input type="text" name="txt1"  value="<%= Request.Form["txt1"] %>"/>
        <button type="submit">GOOOO</button>--%>
        <asp:Literal ID="Literal1" runat="server">12312312</asp:Literal>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>
</body>
</html>
