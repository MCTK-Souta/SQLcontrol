<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucLeft.ascx.cs" Inherits="SQLcontrol.ucLeft" %>
<style>
    body {
        margin: 0;
    }

    ul {
        list-style-type: none;
        margin: 0;
        padding: 0;
        width: 25%;
        background-color: #f1f1f1;
        overflow: auto;
        order: 0;
        flex-direction: row;
    }

    li a {
        display: block;
        color: #000;
        padding: 8px 16px;
        text-decoration: none;
    }

        li a.active {
            background-color: #4CAF50;
            color: white;
        }

        li a:hover:not(.active) {
            background-color: #555;
            color: white;
        }

    .container {
        display: flex;
        justify-content: flex-start;
        height:500px;
    }

    .container2 {
        display: flex;
        justify-content: flex-start;
        order:1;
    }
</style>
<div class="container">
    <ul>
        <li><a href="WebForm1.aspx">增刪修查</a></li>
        <li><a>new</a></li>
        <li><a href="index.html">興趣頁面</a></li>
    </ul>
