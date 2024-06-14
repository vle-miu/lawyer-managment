import React, { Component } from 'react';

export default class ThumnailImageOffice extends Component {
    render() {
        return (
            <img src={this.props.url ? this.props.url : "assets/img/icon/office-thumbnail.jpg"} className="rounded-circle" alt="..."/>
        );
    }
}