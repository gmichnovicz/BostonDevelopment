
var map;
function initMap() {
  var boston ={lat: 42.349179, lng: -71.106476};

  var mapOptions = {
    center: new google.maps.LatLng(boston.lat,boston.lng),
    zoom: 13

  };


  map = new google.maps.Map(document.getElementById('map'),
   mapOptions);
  

  $.getJSON("/api/values", function(json) {

      $.each(json, function(key, data) {
          var lt = data.lat;
          var long = data.long;
          var marker = new google.maps.Marker({
                position: {lat:lt,lng:long}
          });

          var infowindow = new google.maps.InfoWindow();

          google.maps.event.addListener(marker, 'click', (function(marker, key) {
            return function() {

              var contentString = '<div id="content">'+
            '<div id="siteNotice">'+
            '</div>'+
            '<h1 id="firstHeading" class="firstHeading"></h1>'+
            '<div id="bodyContent">'+
            '<p><b></b></p>'+

            '</div>'+
            '</div>';


              infowindow.setContent(contentString);
              infowindow.open(map, marker);
            }
          })(marker, key));

          marker.setMap(map);
    });

    });

  }

