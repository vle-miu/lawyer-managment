import  React, { Component } from 'react';

import FreeConsultSection from '../page-components/freeconsult-page/FreeConsultSection'
import GoogleAdsenseSection from '../common/GoogleAdsenseSection';

export default class FreeConsultPage extends Component {
    render() {
        return (
            <div className="container">
                <FreeConsultSection/>
                <GoogleAdsenseSection/>
            </div>
        );
    }
}