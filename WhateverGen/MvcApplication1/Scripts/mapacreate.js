var clickMarker = null;
var infoWindow;

function initMap() {
    document.getElementById("Zoom").value = 15;

    map = new google.maps.Map(document.getElementById('map'), {
        center: { lat: -34.397, lng: 150.644 },
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

    infoWindow = new google.maps.InfoWindow({ map: map });

    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(function (position) {
            var pos = {
                lat: position.coords.latitude,
                lng: position.coords.longitude
            };
            map.setCenter(pos);
        });
    } else {
        // Browser doesn't support Geolocation
    }

    map.addListener('click', function (e) {
        placeMarkerAndPanTo(e.latLng, map);

        document.getElementById("Latitud").value = e.latLng.lat();
        document.getElementById("Longitud").value = e.latLng.lng();
    });
}

function placeMarkerAndPanTo(latLng, map) {
    if (clickMarker != null)
        clickMarker.setMap(null);
    clickMarker = new google.maps.Marker({
        position: latLng,
        map: map
    });
    map.panTo(latLng);

    infoWindow.open(map, clickMarker);
    infoWindow.setContent("Lat: " + latLng.lat() + '</br>' + "Lon: " + latLng.lng());
}



$(document).ready(function () {
    initMap();
});