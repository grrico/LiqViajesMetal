<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportePanel.aspx.cs" Inherits="MetalLiqViajesReporte.ReportePanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title>Liquidación Viajes Metal</title>

    <%--<meta charset="utf-8">--%>
    <%--<meta name="viewport" content="width=device-width, initial-scale=1">--%>

    <link href="Css/Style.css" rel="stylesheet" />

    <script src="Scripts/jquery-2.2.4.js"></script>

    <%--<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.2/jquery.min.js"></script>--%>
   <%-- <script src="http://ajax.aspnetcdn.com/ajax/jquery.validate/1.11.1/jquery.validate.min.js"></script>--%>
    <%--<script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap-wizard/1.2/jquery.bootstrap.wizard.js"></script>--%>

    <script type="text/javascript">
        $(document).ready(function () {

            var _height = $(window).height() - 30;
            var _width = $(window).width() - 30;

            $('#PanelIframe').height(_height);
            $('#PanelIframe').width(_width);

            $('#Iframe1').height(_height);
            $('#Iframe1').width(_width);

        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid " runat="server">
            <div class="row">
                Reporte Metal
            </div>
            <div class="row">
                <asp:Panel ID="PanelIframe" runat="server">
                    <iframe id="Iframe1" runat="server" frameborder="0" marginwidth="0"></iframe>
                </asp:Panel>
            </div>
        </div>
    </form>
</body>
</html>
