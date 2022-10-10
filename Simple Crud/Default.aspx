<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Enter Category : "></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="btninsert" runat="server" Text="Insert" OnClick="btninsert_Click" />
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
        <asp:Button ID="btndelete" runat="server" Text="Delete" OnClick="btndelete_Click" />

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />

        <br />
        <asp:Label ID="Label2" runat="server" Visible="False"></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="cid" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="cid" HeaderText="cid" InsertVisible="False" ReadOnly="True" SortExpression="cid" />
                <asp:BoundField DataField="cname" HeaderText="cname" SortExpression="cname" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:tbl_studentConnectionString %>" SelectCommand="SELECT * FROM [tblcat]"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
