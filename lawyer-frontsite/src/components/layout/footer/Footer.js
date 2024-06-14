import React, { Component } from 'react';
import { Link } from 'react-router-dom';

export default class Footer extends Component {
    render() {
        return (
            <footer>
                <div className="footer-area">
                    <div className="container">
                        <div className="row">
                            <div className="col-md-6 col-sm-6 col-xs-12">
                                <div className="footer-content">
                                    <div className="footer-head">
                                        <div className="footer-logo">
                                            <h3>Lawyer System</h3>
                                        </div>
                                        <div className="footer-icons">
                                            <ul>
                                                <li><Link to={'#'}><i className="fa fa-facebook"/></Link></li>
                                                <li><Link to={'#'}><i className="fa fa-twitter"/></Link></li>
                                                <li><Link to={'#'}><i className="fa fa-google"/></Link></li>
                                                <li><Link to={'#'}><i className="fa fa-pinterest"/></Link></li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div className="col-md-6 col-sm-6 col-xs-12">
                                <div className="footer-content">
                                    <div className="footer-head">
                                        <h4>information</h4>
                                        <div className="footer-contacts">
                                            <p><span>Tel:</span> +123 456 789</p>
                                            <p><span>Email:</span> contact@example.com</p>
                                            <p><span>Working Hours:</span> 9:00 am - 5:00 pm</p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </footer>
        );
    }
}