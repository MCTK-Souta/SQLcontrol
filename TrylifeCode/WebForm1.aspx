<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TrylifeCode.WebForm1" %>

<%@ Register Src="~/ucA.ascx" TagPrefix="uc1" TagName="ucA" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Button"  OnClick="Button1_Click"/>
    <uc1:ucA runat="server" ID="ucA" />
</asp:Content>
