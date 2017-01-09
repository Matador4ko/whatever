var map;
var marker;

var clickMarker = null;


function initMap() {

    map = new google.maps.Map(document.getElementById('map'), {
        center: { lat: latitud, lng: longitud },
        zoom: 15
        , styles: [
            {
                featureType: 'all',
                stylers: [
                  { saturation: -80 }
                ]
            }, {
                featureType: 'road.arterial',
                elementType: 'geometry',
                stylers: [
                  { hue: '#00ffee' },
                  { saturation: 50 }
                ]
            }, {
                featureType: 'poi.business',
                elementType: 'labels',
                stylers: [
                  { visibility: 'on' }
                ]
            }
        ]
    });
    marker = new google.maps.Marker({ position: { lat: latitud, lng: longitud }, map: map, title: titulo });

    var contentString = '<div id="content">' +
     '<div id="siteNotice">' +
     '</div>' +
     '<h1 id="firstHeading" class="firstHeading">' + titulo + '</h1>' +
     '<div id="bodyContent">' +
     '<p>' + descripcion +
     '<a href="http://localhost:49499/Evento/Details/65537">'+'Ver detalles</a>' +
     '</p>' +
     '</div>' +
     '</div>';

    var infowindow = new google.maps.InfoWindow({
        content: contentString
    });


    map.addListener('click', function (e) {
        infowindow.open(map, marker);
    });
}

$(document).ready(function () {
    initMap();
});