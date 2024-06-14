import React, { Component } from 'react';
import { Route, Switch } from 'react-router-dom';

// Import page contents
import TopPage from '../../page/TopPage';
import ServicesPage from '../../page/ServicesPage';
import AboutPage from '../../page/AboutPage';
import FreeConsultPage from '../../page/FreeConsultPage';
import SearchOfficePage from '../../page/SearchOfficePage';
import OfficeDetailPage from '../../page/OfficeDetailPage';

export default class Body extends Component {
    render() {
        return (
            <Switch>
                <Route exact path='/' component={ TopPage } />
                <Route path='/free-consult' component={ FreeConsultPage } />
                <Route path='/services' component={ ServicesPage } />
                <Route path='/about' component={ AboutPage } />
                <Route path='/search-office' component={ SearchOfficePage } />
                <Route path='/office-detail/:id' component={ OfficeDetailPage } />
            </Switch>
        );
    }
}