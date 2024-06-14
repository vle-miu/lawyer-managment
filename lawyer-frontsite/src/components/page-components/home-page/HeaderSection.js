import  React, { Component } from 'react';
import { Link } from 'react-router-dom';

export default class HeaderSection extends Component { 
    render() {
        return (
            <div className="row bg-overlay">
                <div className="col-md-12 text-center" style={{marginTop: "150px"}}>
                    <h1>Lawyer System</h1>
                    <h4>We're In The Business Of Helping You Start Your Business.</h4>
                    <br/>
                    <Link to={'/free-consult'} className="btn btn-warning btn-lg radius-btn">Free Consult</Link>
                    <Link to={'/search-office'} className="btn btn-primary btn-lg radius-btn mr-left-btn">Search Office</Link>
                </div>
            </div>
        );
    }
}