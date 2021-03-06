﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MarkerOptions.aspx.cs" Inherits="MarkerOptions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?sensor=false"></script>
<script type ="text/javascript">
    var map;
    function initialize() {
        var latlng = new google.maps.LatLng(-34.397, 150.644);
        var myOptions = {
            zoom: 8,
            center: latlng,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };
        map = new google.maps.Map(document.getElementById("map"), myOptions);
        var marker = new google.maps.Marker
        (
            {
                position: new google.maps.LatLng(-34.397, 150.644),
                map: map,
                title: 'Click me'
            }
        );
        var infowindow = new google.maps.InfoWindow({
            content: 'Location info:<br/>Country Name:<br/>LatLng:'
        });
        google.maps.event.addListener(marker, 'click', function () {
            // Calling the open method of the infoWindow 
            infowindow.open(map, marker);
        });
    }
    window.onload = initialize;
</script>

<h2>MarkerOptions Demo:</h2>
<div id ="map" style="height: 512px; width: 974px; top: 60px; left: 27px; position: absolute;"></div>
</asp:Content>

