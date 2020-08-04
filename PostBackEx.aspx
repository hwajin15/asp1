<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostBackEx.aspx.cs" Inherits="WebApplication2.PostBackEx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="다시게시" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="페이지간 게시" PostBackUrl="PostBackEx-1.aspx" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
