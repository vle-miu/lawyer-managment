import React, { Component } from 'react';

import Header from './header/Header';
import Footer from './footer/Footer';
import Body from './body/Body';

export default class App extends Component {
    render() {
        return (
            <React.Fragment>
                <Header/>
                <Body/>
                <Footer/>
            </React.Fragment>
        );
    }
}
