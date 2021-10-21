<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TextBoxControl.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" Height="168px" Rows="5" TextMode="MultiLine"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="TextBox3" runat="server" MaxLength="5">test</asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="TextBox5" runat="server" ToolTip="please enter your name"></asp:TextBox>
            <br />
            <br />
            cached until postback unless set to auto postback (i.e click outside the box)<br />
&nbsp;<asp:TextBox ID="TextBox6" runat="server" AutoPostBack="True"
                Columns="10" OnTextChanged="TextBox6_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="test" />
            <br />
        </div>
    </form>
</body>
</html>
