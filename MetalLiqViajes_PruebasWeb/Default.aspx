<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" Height="16px" Width="340px">
            <asp:ListItem>Addressbar.aspx</asp:ListItem>
            <asp:ListItem>Geocoding.aspx</asp:ListItem>
            <asp:ListItem>GeoCodingCsharp.aspx</asp:ListItem>
            <asp:ListItem>Layers.aspx</asp:ListItem>
            <asp:ListItem>MapOptions.aspx</asp:ListItem>
            <asp:ListItem>MarkerOptions.aspx</asp:ListItem>
            <asp:ListItem>MultipleMarker.aspx</asp:ListItem>
            <asp:ListItem>ReverseGeoCodingDemo.aspx</asp:ListItem>
            <asp:ListItem>YourFirstGoogleMap.aspx</asp:ListItem>            
        </asp:CheckBoxList>  <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

        <asp:Panel ID="PanelIframe" runat="server" CssClass="borderstyle" Height="80%" Width="100%">                        
            <iframe id="Iframe1" runat="server" frameborder="0" marginwidth="0" class="iframe1" visible="True" style="font-family: Arial, Helvetica, sans-serif; font-size: xx-small; width: 951px; height: 645px;"></iframe>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
