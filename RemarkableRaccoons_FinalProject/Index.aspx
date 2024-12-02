﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="RemarkableRaccoons_FinalProject.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Remarkable Raccoons Final Project</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="headers">
                <h1 style="text-align: center">We are the Remarkable Raccoons!</h1>
                <h2 style="text-align: center">Team Members: Colton Ramsey, Lucas Iceman, Ian McDaniel, Saivamsi Amireddy</h2>
            </div>
            <div class="buttons" style="max-width: fit-content; margin-left: auto; margin-right: auto">
                <asp:Button ID="btnIan" runat="server" Text="Solution#" class="btn btn-success"/>
                <asp:Button ID="btnColton" runat="server" Text="Solution#" class="btn btn-success"/>
                <asp:Button ID="btnSai" runat="server" Text="Solution#" class="btn btn-success"/>
                <asp:Button ID="btnLucas" runat="server" Text="Solution#" class="btn btn-success"/>
            </div>
        </div>
    </form>
</body>
</html>
