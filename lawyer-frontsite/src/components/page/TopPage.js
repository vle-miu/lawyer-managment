import  React, { Component } from 'react';

import HeaderSection from '../page-components/home-page/HeaderSection';
import SliderSection from '../page-components/home-page/SliderSection';
import GoogleAdsenseSection from '../common/GoogleAdsenseSection';
import AreaListSection from '../common/AreaListSection';

export default class TopPage extends Component {
    render() {
        return (
            <React.Fragment>
                <HeaderSection/>
                <div className="container">
                    <SliderSection/>
                    <AreaListSection/>
                    <GoogleAdsenseSection/>
                </div>
            </React.Fragment>
        );
    }
}