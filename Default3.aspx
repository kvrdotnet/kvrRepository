<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default3.aspx.vb" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="t1" runat="server"></asp:TextBox>
&nbsp;
        <asp:TextBox ID="t2" runat="server"></asp:TextBox>
&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="t1" ErrorMessage="Invalid date" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
    
    </div>
    </form>
</body>
</html>
