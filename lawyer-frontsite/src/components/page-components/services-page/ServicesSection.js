import  React, { Component } from 'react';

import Section from '../../common/Section';

export default class ServicesSection extends Component {
    render() {
        return (
            <Section title="Services Information" content={<ServicesContent/>}/>
        )
    }
}

class ServicesContent extends Component {
    render() {
        return (
            <h6>Here is content of Services Page!</h6>
        );
    }
}