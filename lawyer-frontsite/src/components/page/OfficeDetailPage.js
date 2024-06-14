import  React, { Component } from 'react';

import DetailOfficeSection from '../page-components/detailoffice-page/DetailOfficeSection';
import ListOfficeByAreaSection from '../page-components/detailoffice-page/ListOfficeByAreaSection';
import GoogleAdsenseSection from '../common/GoogleAdsenseSection';

export default class OfficeDetailPage extends Component {
    render() {
        return (
            <div className="container">
                <DetailOfficeSection id={this.props.match.params.id}/>
                <ListOfficeByAreaSection/>
                <GoogleAdsenseSection/>
            </div>
        );
    }
}