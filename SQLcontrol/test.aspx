<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="SQLcontrol.test" %>

<%@ Register Src="~/ucPager.ascx" TagPrefix="uc1" TagName="ucPager" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table border="1">
            <asp:Repeater runat="server" ID="repList">
                <ItemTemplate>
                    <tr>
                        <td>Val1</td><td>Val2</td><td>Val3</td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <uc1:ucPager runat="server" id="ucPager" PageingSize="12" SType="Inner"/>
    </form>
</body>
</html>
