<%@ Page Language="C#" AutoEventWireup="true" CodeFile="report1.aspx.cs" Inherits="report1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Enter Subcategory : "></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click" />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
