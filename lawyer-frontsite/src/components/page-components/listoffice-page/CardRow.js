import  React, { Component } from 'react';
import { Link } from 'react-router-dom';

import ThumnailImageOffice from '../../common/ThumbnailImageOffice';

export default class CardRow extends Component {

    render() {
        return (
            <li className="list-group-item">
                <div className="card border-info">
                    <div className="card-body">
                        <div className="row">
                            <div className="col-md-2">
                                <ThumnailImageOffice/>
                            </div>
                            <div className="col-md-10">
                                <Link to={'/office-detail/' + this.props.obj.id}><h6 className="card-title"><b>{this.props.obj.name}</b></h6></Link>
                                <p className="card-text"><b>Address:</b> {this.props.obj.address}</p>
                                <p className="card-text"><b>Phone:</b> {this.props.obj.phone}</p>
                                <p className="card-text"><b>Email:</b> {this.props.obj.email}</p>
                            </div>
                        </div>
                        <div className="row" style={{marginTop: "15px", paddingLeft: "15px", paddingRight: "15px"}}>
                            <p>{this.props.obj.introduction}</p>
                        </div>
                    </div>
                </div>
            </li>
        );
    }

}