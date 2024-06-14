import Env from '../environments'

export default class APIService {

    static baseUrl() { return Env.BASE_URL; }
    
    static parseUrl(url) { return APIService.baseUrl() + url; }
    
    static generateHeaders(token) {
        let headers = {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }

        if (token) {
            headers['Authorization'] = 'Bearer ' + token;
        }

        return headers;
    }

}