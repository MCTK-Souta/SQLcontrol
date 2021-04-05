<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SQLcontrol.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <a href="WebForm2.aspx">回上頁</a>
    <form id="form1" runat="server">

        姓：<asp:TextBox ID="FirstName" runat="server"></asp:TextBox><br />
        名：<asp:TextBox ID="LastName" runat="server"></asp:TextBox><br />
        生日:<asp:TextBox ID="Birthday" runat="server" TextMode="Date" ></asp:TextBox>
        性別:<asp:RadioButtonList RepeatDirection="Horizontal" RepeatLayout="Flow" ID="Sex" runat="server">
            <asp:ListItem Value="男">男</asp:ListItem>
            <asp:ListItem Value="女">女</asp:ListItem>
            </asp:RadioButtonList>
        <br />
        地址:<asp:TextBox ID="Address" runat="server"></asp:TextBox><br />
        身分證字號(帳號):<asp:TextBox ID="IDN" runat="server" ></asp:TextBox>(查詢用Key)<br />
        密碼:<asp:TextBox ID="Password" runat="server" Textmode="Password"></asp:TextBox><br />
        電子信箱:<asp:TextBox ID="Email" runat="server" TextMode="Email"></asp:TextBox><br />
        聯絡電話:<asp:TextBox ID="Phone" runat="server" TextMode="Phone"></asp:TextBox><br />
        最高學歷:<asp:DropDownList ID="Education" runat="server">
            <asp:ListItem Value="1">國小</asp:ListItem>
            <asp:ListItem Value="2">國中</asp:ListItem>
            <asp:ListItem Value="3">高中職</asp:ListItem>
            <asp:ListItem Value="4">大學</asp:ListItem>
            <asp:ListItem Value="5">研究所</asp:ListItem>
            </asp:DropDownList><br />
        學校:<asp:TextBox ID="School" runat="server"></asp:TextBox>
        系別:<asp:TextBox ID="Department" runat="server" ></asp:TextBox><br />
        是否有過程式經驗:
        <asp:RadioButtonList RepeatDirection="Horizontal" RepeatLayout="Flow" ID="Exp" runat="server">
            <asp:ListItem Value="無"></asp:ListItem>
            <asp:ListItem Value="有"></asp:ListItem>
        </asp:RadioButtonList>&nbsp&nbsp
        年數:<asp:DropDownList ID="Expyear" runat="server">
            <asp:ListItem Value="1">未滿1年</asp:ListItem>
            <asp:ListItem Value="2">1年</asp:ListItem>
            <asp:ListItem Value="3">2年</asp:ListItem>
            <asp:ListItem Value="4">3年以上</asp:ListItem>
            </asp:DropDownList><br />

        <asp:Button ID="Select" runat="server" Text="查詢" OnClick="Button1_Click" />
        <asp:Button ID="Add" runat="server" Text="新增" OnClick="Button2_Click" />
        <asp:Button ID="UPdate" runat="server" Text="修改" OnClick="Button3_Click" />
        <asp:Button ID="Delete" runat="server" Text="刪除" OnClick="Button4_Click" />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>

    </form>
</body>
</html>
