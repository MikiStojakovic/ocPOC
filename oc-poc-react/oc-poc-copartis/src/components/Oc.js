import React, { Component } from 'react';
import axios from 'axios';

class Oc extends Component {
  state = {
    oc: null
  };
  componentDidMount() {
    console.log('start componentDidMount');
    let id = this.props.match.params.id;
    let api = 'http://localhost:54188/api/oc/' + id;
    axios.get(api).then(response => {
      this.setState({ oc: response.data });
    });
  }
  render() {
    const oc = this.state.oc ? (
      <div className="post">
        <h4 className="center">Oc reference: {this.state.oc.ocRef}</h4>
        <p>Description: {this.state.oc.ocRef}</p>
      </div>
    ) : (
      <div className="center">Loading post...</div>
    );
    return <div className="container">{oc}</div>;
  }
}

export default Oc;
