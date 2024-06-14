import React, { Component } from 'react';

export default class Section extends Component {
    render() {
        return (
            <section className="section">
                <div className="row section-title">
                    <h5>{this.props.title}</h5>
                </div>
                <div className="row section-content">
                    {this.props.content}
                </div>
            </section>
        );
    }
}