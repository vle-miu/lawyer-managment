import  React, { Component } from 'react';

import Section from '../common/Section';

export default class GoogleAdsenseSection extends Component {
    render() {
        return (
            <Section title="Google Adsense" content={<GoogleAdsenseContent/>}/>
        );
    }
}

class GoogleAdsenseContent extends Component {
    render() {
        return (
            <img src="/assets/img/google-adsense/google-adsense-static.jpg" alt="..." width="100%"></img>
        );
    }
}