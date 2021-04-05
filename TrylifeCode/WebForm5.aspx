<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="TrylifeCode.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Repeater runat="server" ID="Repeater1" OnDataBinding="Repeater1_ItemDataBound">
            <ItemTemplate>
                <p>
                    ID:<%# Eval("ID") %> <br />
                    Name:<%# Eval("Name") %> <br />
                    <asp:Literal runat="server" ID="Literal1"></asp:Literal>
                </p>
            </ItemTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
