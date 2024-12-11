<!--
* Name: Colton Ramsey, Lucas Iceman, Ian McDaniel
* email: ramseyc6@mail.uc.edu, icemanlc@mail.cu.edu, mcdaniip@mail.uc.edu
* Assignment Number: Final Exam
* Due Date: 12/12/2024
* Course #/Section: IS3050-002 
* Semester/Year: Fall 2024
* Brief Description of the assignment: Use asp.net to run leet code solutions.
* Citations: https://leetcode.com/problems/maximum-score-words-formed-by-letters/description/, https://chatgpt.com/
* Anything else that's relevant:
-->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="RemarkableRaccoons_FinalProject.Index" %>

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
                <h1 style="text-align: center; font-weight: bold; font-size: 52px">We are the Remarkable Raccoons!</h1>
                <h2 style="text-align: center; font-size: 36px">Team Members: Colton Ramsey, Lucas Iceman, Ian McDaniel, Saivamsi Amireddy</h2>
            </div>
            <div class="buttons" style="max-width: fit-content; margin-left: auto; margin-right: auto">
                <asp:Button ID="btnClear" runat="server" Text="Clear Leetcode Solution" class="btn btn-default" style="font-size: 22px" OnClick="btnClear_Click"/>
                <asp:Button ID="btnIan" runat="server" Text="Solution #1255" class="btn btn-success" style="font-size: 22px" OnClick="btnIan_Click"/>
                <asp:Button ID="btnColton1" runat="server" Text="Solution #123" class="btn btn-info" style="font-size: 22px" OnClick="btnColton1_Click"/>
                <asp:Button ID="btnColton2" runat="server" Text="Solution #3382" class="btn btn-warning" style="font-size: 22px" OnClick="btnColton2_Click"/>
                <asp:Button ID="btnLucas" runat="server" Text="Solution #420" class="btn btn-danger" style="font-size: 22px" OnClick="btnLucas_Click"/>
                <br />
            </div>
            <div class="results" style="max-width: fit-content; margin-left: auto; margin-right: auto; text-align: center">
                <br />
                <asp:Label ID="lblLeetCode" runat="server" Text="" style="font-weight: bold; font-size: 24px"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblDescription" runat="server" Text="" style="font-size: 18px"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblInputValues" runat="server" Text="" style="font-size: 18px"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblResults" runat="server" Text="" style="font-size: 24px; font-weight: bold"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblSolution1" runat="server" Text="" style="font-size: 18px"></asp:Label>
                <asp:Label ID="lblSolution2" runat="server" Text="" style="font-size: 18px"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
