import  React, { Component } from 'react';

import ServicesSection from '../page-components/services-page/ServicesSection';
import GoogleAdsenseSection from '../common/GoogleAdsenseSection';

export default class ServicesPage extends Component {
    render() {
        return (
            <div className="container">
                <ServicesSection/>
                <GoogleAdsenseSection/>
            </div>
        );
    }
}

