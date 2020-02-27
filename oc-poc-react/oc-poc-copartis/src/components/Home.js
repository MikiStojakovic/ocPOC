import React, { Component } from 'react';
import axios from 'axios';
import { Link } from 'react-router-dom';
import Pokeball from '../pokeball.png';
import { connect } from 'react-redux';

class Home extends Component {
  // state = {
  //   ocs: []
  // };
  // componentDidMount() {
  //   axios.get('http://localhost:54188/api/oc').then(response => {
  //     console.log(response.data);
  //     this.setState({
  //       ocs: response.data
  //     });
  //   });
  // }
  render() {
    const { ocs } = this.props;
    console.log(ocs);
    const ocsList = ocs.length ? (
      ocs.map(oc => {
        console.log(oc);
        return (
          <div className="post card" key={oc.id}>
            <img src={Pokeball} alt="oc" />
            <div className="card-content">
              <Link to={'/' + oc.id}>
                <span className="card-title red-text">{oc.ocRef}</span>
              </Link>
              <p>{oc.propertyOne}</p>
            </div>
          </div>
        );
      })
    ) : (
      <div className="center">No ocs yet</div>
    );
    return (
      <div className="container home">
        <h1 className="center blue-text">Ouverture compte - home</h1>
        {ocsList}
      </div>
    );
  }
}

const mapStateToProps = state => {
  return {
    ocs: state.ocs
  };
};

export default connect(mapStateToProps)(Home);
