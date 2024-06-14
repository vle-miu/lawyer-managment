import APIService from "./APIService"

export default class LawyerOfficeService extends APIService {

    static findNearestLawyerOffice = (url, location) => {
        return fetch(this.parseUrl(url), {
            method: 'GET',
            headers: this.generateHeaders(),  
        }).then(res => res.json());
    }

    static getLawyerOfficeById(url) {
        return fetch(this.parseUrl(url), {
            method: 'GET',
            headers: this.generateHeaders(),  
        }).then(res => res.json());
    }

}