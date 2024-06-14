import Env from '../environments'

export default class GoogleService {

    static ipLookupUrl() { 
        return Env.IP_LOOKUP_URL; 
    }

    static googleMapEmbedUrl() {
        return Env.GOOGLE_MAP_EMBED_URL;
    }

    static getCurrentLocation = async () => {
        if ('geolocation' in navigator) {
            navigator.geolocation.getCurrentPosition(
                location => {
                    return { 
                        lat: location.coords.latitude,
                        lon: location.coords.longitude
                    };
                }, 
                error => {
                    this.getCurrentLocationByIpAddress();
                },
                {
                    enableHighAccuracy: true, 
                    maximumAge: 30000, 
                    timeout: 27000
                }
            );
        } else {
            this.getCurrentLocationByIpAddress();
        }
    }

    static getCurrentLocationByIpAddress = async () => {
        let location = {};
        let response = await fetch(GoogleService.ipLookupUrl());
        let locationInfo = await response.json();

        location.lat = locationInfo.lat;
        location.lon = locationInfo.lon;
        return location;
    }

}