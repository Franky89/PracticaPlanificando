// JavaScript source code
var map = null;
var popup = L.popup();

$(document).ready(function () {
    map = L.map('mapa').setView([40.51298, -3.34954], 10);
    
    L.tileLayer('http://{s}.tiles.mapbox.com/v3/dennisl.map-6g3jtnzm/{z}/{x}/{y}.png', {
        maxZoom: 18
    }).addTo(map);

    var epsIcon = L.icon({
        iconUrl: 'images/eps.jpg',
        iconSize: [64, 64],
        iconAnchor: [32, 64],
    });


   
    $(window).resize(function () {
        $('.container').css(
		{
		    position: 'absolute',
		    left: ($(window).width() - $('.container').outerWidth()) / 1.25,
		    top: ($(window).height() - $('.container').outerHeight()) / 1.05
		});
    });

    $(window).resize();

    map.on('click', onMapClick);
   
});
function onMapClick(e) {
    
    $('#Coordenadas').attr('value', e.latlng.toString());
   
    popup
        .setLatLng(e.latlng)
   
        .setContent("As pinchado en: " + e.latlng.toString())
        .openOn(map);
   
   

}




