import  React, { Component } from 'react';

import Section from '../../common/Section';

export default class FreeConsultSection extends Component {
    render() {
        return (
            <Section title="Free Consult" content={<FreeConsultContent/>}/>
        )
    }
}

class FreeConsultContent extends Component {
    render() {
        return (
            <h6>Here is content of Free Consult Page!</h6>
        );
    }
}