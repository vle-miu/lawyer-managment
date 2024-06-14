import  React, { Component } from 'react';

import Section from '../../common/Section';
import OfficeCard from '../detailoffice-page/OfficeCard';

export default class DetailOfficeSection extends Component {
    render() {
        return (
            <Section title="Office Information" content={<DetailOfficeContent id={this.props.id}/>}/>
        );
    }
}

class DetailOfficeContent extends Component {
    render() {
        return (
            <OfficeCard id={this.props.id}/>
        );
    }
}