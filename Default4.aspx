<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default4.aspx.vb" Inherits="Default4" Culture="en-GB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     Start Date: <asp:TextBox ID="txtStartDate" runat="server" Text = "24/02/1999"></asp:TextBox>&nbsp;
    End Date: <asp:TextBox ID="txtEndDate" runat="server" Text = "31/12/1988"></asp:TextBox><br />
    <asp:CompareValidator ID="CompareValidator1" ValidationGroup = "Date" ForeColor = "Red" runat="server" 
        ControlToValidate = "txtStartDate" ControlToCompare = "txtEndDate" Operator = "LessThan" Type = "Date" 
        ErrorMessage="Start date must be less than End date."></asp:CompareValidator>
    <br />
    <asp:Button ID="btnCompare" runat="server" Text="Compare" ValidationGroup = "Date"/>
    </div>
    </form>
</body>
</html>
