import React, { Component } from 'react';
import axios from 'axios';

class Home extends Component {
  state = {
    ocs: []
  };
  componentDidMount() {
    axios.get('http://localhost:54188/api/oc').then(response => {
      console.log(response.data);
      this.setState({
        ocs: response.data
      });
    });
  }
  render() {
    const { ocs } = this.state;
    console.log(this.state);
    console.log('ocs');
    console.log(ocs);
    const ocsList = ocs.length ? (
      ocs.map(oc => {
        console.log(oc);
        return (
          <div className="post card" key={oc.id}>
            <div className="card-content">
              <span className="card-title">{oc.ocRef}</span>
              <p>{oc.propertyOne}</p>
            </div>
          </div>
        );
      })
    ) : (
      <div className="center">No ocs yet</div>
    );
    return (
      <div className="container">
        <h1 className="center blue-text">Ouverture compte - home</h1>
        {ocsList}
      </div>
    );
  }
}

export default Home;
