
var map;
var infowindow;
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

          //var infowindow = new google.maps.InfoWindow();
          infowindow = new google.maps.InfoWindow();
          google.maps.event.addListener(marker, 'click', (function(marker, key) {
            return function() {
              var x = 'OK'

              var contentString = '<div id="content">'+
            '<div id="siteNotice">'+
            '</div>'+

            '<h1 id="firstHeading" class="firstHeading" align="center">'+data.address+'</h1>'+

            '<div id="bodyContent">'+
            
            '<img src="http://www.bostonplans.org'+data.imgSrc+'" width="300" height="300" class="center">'+
            '<p></p>'+
            '<p style="font-size:160%;"><b>Project Status: </b>'+ data.projectStatus+'</p>'+
            
            '<p style="font-size:160%;"><b>Neighborhood: </b>'+data.neighborhood+'</p>'+
            '<p style="font-size:160%;"><b>Land Square Feet: </b>'+data.landSqFt+'</p>'+
            '<p style="font-size:160%;"><b>Build Size: </b>'+data.buildSize+'</p>'+
            '<p style="font-size:160%;"> <a href="'+data.planSrc+'">More information here.</a>'+
            
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

