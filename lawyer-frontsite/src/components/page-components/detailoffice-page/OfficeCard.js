import  React, { Component } from 'react';

import ThumnailImageOffice from '../../common/ThumbnailImageOffice';

import GoogleService from '../../../services/GoogleService';
import LawyerOfficeService from '../../../services/LawyerOfficeService';
import ENV from '../../../environments';

export default class OfficeCard extends Component {

    constructor(props) {
        super(props);
        this.route = this.route.bind(this);
        this.state = {
            office: {},
            googleMapUrl: ''
        }
    }

    componentDidMount() {
        
        LawyerOfficeService.getLawyerOfficeById('/api/lawyeroffice/' + this.props.id)
            .then(office => {
                var key = '?key=' + ENV.GOOGLE_API_KEY;
                var q = '&q=' + office.latitude + ',' + office.longtitude;
                var center = '&center=' + office.latitude + ',' + office.longtitude;
                var optionParams = '&zoom=17';

                var gooogleMapUrl = GoogleService.googleMapEmbedUrl() + 'place' + key + q + center + optionParams;

                this.setState({
                    office: office,
                    googleMapUrl: ENV.GOOGLE_MAP_EMBED_URL_DEMO
                });
            })
            .catch(error => {
                alert("Not found lawyer office");
            })
    }

    route() {
        GoogleService.getCurrentLocationByIpAddress()
            .then((location) => {
                if (location) {
                    var key = '?key=' + ENV.GOOGLE_API_KEY;
                    var origin = '&origin=' + location.lat + ',' + location.lon;
                    var destination = '&destination=' + this.state.office.latitude + ',' + this.state.office.longtitude; 
                    var googleMapUrl = GoogleService.googleMapEmbedUrl() + 'directions' + key + origin + destination;

                    this.setState({
                        googleMapUrl: ENV.GOOGLE_MAP_EMBED_URL_DEMO
                    })
                }
            });
    }

    render() {
        return (
            <div className="card" style={{width: "100%", paddingTop: "15px", paddingLeft: "30px", paddingRight: "30px"}}>
                <div className="row">
                    <h5><b>{this.state.office.name}</b></h5>
                </div>
                <div className="row">
                    <div className="col-md-4"/>
                    <div className="col-md-4">
                        <ThumnailImageOffice url={'../' + this.state.office.imgProfile}/>
                    </div>
                    <div className="col-md-4"/>
                </div>
                <div className="row">
                    <p>{this.state.office.introduction}</p>
                </div>
                <div className="row">
                    <p><b>Address: </b>{this.state.office.address}</p>
                </div>
                <div className="row">
                    <div className="col-md-1"/>
                    <div className="col-md-10">
                        <iframe width="100%" height="500px" src={this.state.googleMapUrl} title="map"/>
                        <div className="row">
                            <div className="col-md-3"/>
                            <div className="col-md-6" style={{textAlign: "center"}}>
                                <button type="button" className="btn btn-info mr-left-btn" onClick={this.route}>Route</button>
                                <button type="button" className="btn btn-info mr-left-btn">FullScreen</button>
                                <button type="button" className="btn btn-info mr-left-btn">Print</button>
                            </div>
                            <div className="col-md-3"/>
                        </div>
                    </div>
                    <div className="col-md-1"/>
                </div>
                <br/>
                <div className="row">
                    <ul style={{width: "100%"}}>
                        <li>
                            <b>Lawyer List</b>
                            <table className="table">
                                <thead class="thead-light">
                                    <tr>
                                        <th>Lawyer Code</th>
                                        <th>Lawyer Name</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>0001</td>
                                        <td>Nguyen Van A</td>
                                    </tr>
                                    <tr>
                                        <td>0002</td>
                                        <td>Nguyen Van B</td>
                                    </tr>
                                </tbody>
                            </table>
                        </li>
                        <li>
                            <b>Working Time</b>
                            <p>{this.state.office.workingTime}</p>
                        </li>
                        <li>
                            <b>Contact</b>
                            <table>
                                <tbody>
                                    <tr>
                                        <td>Email:</td>
                                        <td>{this.state.office.email}</td>
                                    </tr>
                                    <tr>
                                        <td>Phone:</td>
                                        <td>{this.state.office.phone}</td>
                                    </tr>
                                </tbody>
                            </table>
                        </li>
                        <li>
                            <b>Homepage</b>
                            <div><a href={this.state.office.homePage}>{this.state.office.homePage}</a></div>
                        </li>
                        <li>
                            <b>Others</b>
                            <p>{this.state.office.others}</p>
                        </li>
                    </ul>
                </div>
            </div>
        );
    }
}