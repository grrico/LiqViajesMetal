function altura() {
  
    var _height = $(window).height()-30;
    var _width = $(window).width()-30;

    
    $('#PanelIframe').height(_height);
    $('#PanelIframe').width(_width);

    $('#Iframe1').height(_height);
    $('#Iframe1').width(_width);      
};
