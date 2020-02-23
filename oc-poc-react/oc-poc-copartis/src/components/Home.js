import React, { Component } from 'react';
import axios from 'axios';

class Home extends Component {
  componentDidMount() {
    axios
      .get('http://localhost:54188/api/oc')
      .then(response => console.log(response));
  }
  render() {
    return (
      <div className="container">
        <h1 className="center blue-text">Ouverture compte - home</h1>
      </div>
    );
  }
}

export default Home;
