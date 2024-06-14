import React, { Component } from 'react';
import { Link } from 'react-router-dom';

export default class NavBar extends Component {
    render() {
        return (
            <nav className="nav-menu d-none d-lg-block">
                <ul>
                    <li className="active"><Link to={'/'}>Home</Link></li>
                    <li><Link to={'/services'}>Services</Link></li>
                    <li><Link to={'/about'}>About</Link></li>
                </ul>
            </nav>
        );
    }
}