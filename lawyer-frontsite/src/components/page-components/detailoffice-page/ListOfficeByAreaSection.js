import  React, { Component } from 'react';

import Section from '../../common/Section';

export default class ListOfficeByAreaSection extends Component {
    render() {
        return (
            <Section title="List Office by Area" content={<ContentListOfficeByArea/>}/>
        );
    }
}

class ContentListOfficeByArea extends Component {
    render() {
        return (
            <h6>Here is content of list offices by area!</h6>
        );
    }
}