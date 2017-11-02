<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReporteViajes01.aspx.cs" Inherits="MetalLiqViajesReporte.ReporteViajes01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title>Liquidación Viajes Metal</title>
    
    <%--<meta charset="utf-8">--%>
    <%--<meta name="viewport" content="width=device-width, initial-scale=1">--%>

    <link href="Css/Style.css" rel="stylesheet" />
<%--    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.2.1.js"></script>
    <script src="Scripts/bootstrap.js"></script>--%>

</head>
<body>
    <form id="form1" runat="server">

        <div class="container-fluid " runat="server">
            <div class="row">
                <div class="col-md-6 text-uppercase Encabezadoh1">
                    <h3>Metal LTDA</h3>
                </div>
                <div class="col-md-6 text-uppercase text-right Encabezadoh1">
                    <h3>
                        <asp:Label ID="LabelTitulo" runat="server" Text="LEGALIZACION VIAJE @NUMEROVIAJE"></asp:Label></h3>
                </div>
            </div>
        </div>

        <div class="container-fluid " runat="server">
            <div class="row">
                <div class="col-md-12 text-uppercase">
                    <asp:Label ID="LabelNit" runat="server" Text="Nit: 800218656-0"></asp:Label></div>
            </div>
            <div class="row">
                <div class="col-md-4 text-uppercase">
                    <asp:Label ID="LabelDireccion" runat="server" Text="Calle 73# 42-65 Autopista Sur"></asp:Label></div>
                <div class="col-md-2 text-uppercase">
                    <asp:Label ID="Label1" runat="server" Text="Teléfono: 376 23 79"></asp:Label></div>
                <div class="col-md-6 text-uppercase text-right">
                    <asp:Label ID="LabelFecha" runat="server" Text="Fecha Movimiento: @FECHA"></asp:Label></div>
            </div>
            <div class="row">
                <div class="col-md-4 text-uppercase">
                    <asp:Label ID="LabelPlaca" runat="server" Text="Placa: @PLACA"></asp:Label></div>
                <div class="col-md-2 text-uppercase">
                    <asp:Label ID="LabelCCosto" runat="server" Text="Centro Costo: @CCOSTO"></asp:Label></div>
                <div class="col-md-3 text-uppercase">
                    <asp:Label ID="LabelMarca" runat="server" Text="Marca: @MARCA"></asp:Label></div>
                <div class="col-md-3 text-uppercase text-right">
                    <asp:Label ID="LabelModelo" runat="server" Text="Modelo: @MODELO"></asp:Label></div>
            </div>
        </div>

        <hr />

        <div class="container-fluid marco" runat="server">
            <div class="row">
                <div class="col-md-2 text-uppercase">Cédula</div>
                <div class="col-md-4 text-uppercase">Nombre Conductor</div>
                <div class="col-md-2 text-uppercase">Valor Anticipo</div>
                <div class="col-md-2 text-uppercase">Valor Gasto</div>
                <div class="col-md-2 text-uppercase">Total</div>
            </div>
        </div>

        <div class="container-fluid marco" runat="server">
            <div class="row">
                <div class="col-md-2 text-uppercase">
                    <asp:Label ID="LabelCedula" runat="server" Text="Label"></asp:Label></div>
                <div class="col-md-4 text-uppercase">
                    <asp:Label ID="LabelNombreConductor" runat="server" Text="Label"></asp:Label></div>
                <div class="col-md-2 text-uppercase">
                    <asp:Label ID="LabelAnticipo" runat="server" Text="Label"></asp:Label></div>
                <div class="col-md-2 text-uppercase">
                    <asp:Label ID="LabelGasto" runat="server" Text="Label"></asp:Label></div>
                <div class="col-md-2 text-uppercase text-right ">
                    <asp:Label ID="LabelTotal" runat="server" class="text-right" Text="Label"></asp:Label></div>
            </div>
        </div>

        <br />

        <div id="DetEncabezado">
            <div id="TramosLiquidados2" class="container-fluid marco" runat="server"></div>
        </div>

        <br />

        <div id="Tramos">
            <div id="TramosAnticipo2" class="container-fluid marco" runat="server"></div>
        </div>

        <br />

        <div id="TramosMovViajes">
            <div id="TramosMovimiento" class="container-fluid marco" runat="server"></div>
        </div>

    </form>
</body>
</html>
