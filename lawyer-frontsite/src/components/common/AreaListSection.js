import  React, { Component } from 'react';

import Section from '../common/Section';

export default class AreaListSection extends Component {
    render() {
        return (
            <Section title="Search by Area" content={<AreaListContent/>}/>
        );
    }
}

class AreaListContent extends Component {
    render() {
        return (
            <div className="row">
                <div className="col-md-1"/>
                <div className="col-md-10">
                    <ul className="list-group list-group-horizontal row" style={{textAlign: "center"}}>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">北海道</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">青森県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">岩手県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">宮城県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">秋田県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">山形県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">福島県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">茨城県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">栃木県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">群馬県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">埼玉県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">千葉県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">東京都</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">神奈川県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">新潟県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">富山県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">石川県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">福井県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">山梨県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">長野県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">岐阜県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">静岡県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">愛知県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">三重県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">滋賀県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">京都府</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">大阪府</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">兵庫県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">奈良県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">和歌山県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">鳥取県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">島根県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">岡山県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">沖縄県</a></li>
                        <li className="list-group-item col-md-2 item-area"><a href="/area">鹿児島県</a></li>
                    </ul>
                </div>
                <div className="col-md-1"/>

            </div>
        );
    }
}