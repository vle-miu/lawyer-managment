import React, { Component } from 'react';
import { Link } from 'react-router-dom';

import NavBar from '../../common/NavBar';

export default class Header extends Component {
    render() {
        return (
            <header id="header" >
                <div className="container d-flex">
                    <div className="logo mr-auto">
                        <h1 className="text-light">
                            <Link to={'/'} className="nav-brand"><img src="assets/img/logo.png" alt="" className="img-fluid"/></Link>
                        </h1>
                    </div>
                    <NavBar/>
                </div>
            </header>
        );
    }
}