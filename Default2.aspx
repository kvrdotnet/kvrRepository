<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Save and Download Files from file system</title>
<style type="text/css">
.modalBackground
{
background-color: Gray;
filter: alpha(opacity=80);
opacity: 0.8;
z-index: 10000;
}

.GridviewDiv {font-size: 100%; font-family: 'Lucida Grande', 'Lucida Sans Unicode', Verdana, Arial, Helevetica, sans-serif; color: #303933;}
Table.Gridview{border:solid 1px #df5015;}
.Gridview th{color:#FFFFFF;border-right-color:#abb079;border-bottom-color:#abb079;padding:0.5em 0.5em 0.5em 0.5em;text-align:center}
.Gridview td{border-bottom-color:#f0f2da;border-right-color:#f0f2da;padding:0.5em 0.5em 0.5em 0.5em;}
.Gridview tr{color: Black; background-color: White; text-align:left}
:link,:visited { color: #DF4F13; text-decoration:none }

</style>
</head>
<body>
<form id="form1" runat="server">
<div>
<asp:FileUpload ID="fileUpload1" runat="server" /><br />
    <asp:Button ID="Button1" runat="server" Text="Upload" />
<asp:Button ID="btnUpload" runat="server" Text="Upload" onclick="btnUpload_Click" />
</div>
<div>
<asp:GridView ID="gvDetails" CssClass="Gridview" runat="server" AutoGenerateColumns="false" DataKeyNames="FilePath">
<HeaderStyle BackColor="#df5015" />
<Columns>
<asp:BoundField DataField="Id" HeaderText="Id" />
<asp:BoundField DataField="FileName" HeaderText="FileName" />
<asp:TemplateField HeaderText="FilePath">
<ItemTemplate>
    <asp:ImageButton ID="ImgBtn" runat="server" Width="50" ImageUrl="~/download.jpg" OnClick="ImgBtn_Click" />
<%--<asp:LinkButton ID="lnkDownload" runat="server" Text="Download" OnClick="lnkDownload_Click"></asp:LinkButton>--%>
</ItemTemplate>
</asp:TemplateField>
</Columns>
</asp:GridView>
</div>
</form>
</body>
</html>
