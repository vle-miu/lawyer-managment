import  React, { Component } from 'react';

import Section from '../../common/Section';
import CardRow from './CardRow';

export default class ListOfficeSection extends Component {

    cardRow() {
        if (this.props.items && this.props.items.length > 0) {
            return this.props.items.map(function (office, i) {
                return <CardRow obj={office} key={i}/>
            })
        }
    }

    render() {
        return (
            <Section 
                title="List Offices" 
                content={
                    <ul className="list-group" style={{width: "100%"}}>
                        {this.cardRow()}
                    </ul>
                }/>
        );
    }
}