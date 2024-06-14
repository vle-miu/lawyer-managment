import  React, { Component } from 'react';
import GoogleService from '../../services/GoogleService';
import LawyerOfficeService from '../../services/LawyerOfficeService';

import ListOfficeSection from '../page-components/listoffice-page/ListOfficeSection';
import GoogleAdsenseSection from '../common/GoogleAdsenseSection';

export default class SearchOfficePage extends Component {

    constructor(props) {
        super(props);
        this.state = {
            location: {},
            offices: []
        }
    }

    componentDidMount() {
        GoogleService.getCurrentLocationByIpAddress()
            .then((location) => {
                if (location) {
                    this.setState({
                        location: location  
                    });

                    LawyerOfficeService.findNearestLawyerOffice('/api/lawyeroffice', location)
                    .then(res => {
                        console.log(res);
                        this.setState({
                            offices: res
                        });
                    })
                    .catch(error => {alert("Not found lawyer offices")})
                }
            });
    }

    render() {
        return (
            <div className="container">
                <ListOfficeSection items={this.state.offices}/>
                <GoogleAdsenseSection/>
            </div>
        );
    }
}