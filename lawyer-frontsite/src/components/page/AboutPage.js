import  React, { Component } from 'react';

import ContactInfoSection from '../page-components/about-page/ContactInfoSection';
import GoogleAdsenseSection from '../common/GoogleAdsenseSection';

export default class AboutPage extends Component {
    render() {
        return (
            <div className="container">
                <ContactInfoSection/>
                <GoogleAdsenseSection/>
            </div>
        );
    }
}

