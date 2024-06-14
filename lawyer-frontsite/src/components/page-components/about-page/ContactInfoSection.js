import  React, { Component } from 'react';

import Section from '../../common/Section';

export default class ContactInfoSection extends Component {
    render() {
        return (
            <Section title="Contact Information" content={<AboutContent/>}/>
        )
    }
}

class AboutContent extends Component {
    render() {
        return (
            <h6>Here is content of About Page!</h6>
        );
    }
}