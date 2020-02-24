import React, { Component } from 'react';
import axios from 'axios';

class Oc extends Component {
  state = {
    oc: null
  };
  componentDidMount() {
    let id = this.props.match.params.id;
    let api = 'http://localhost:54188/api/oc/' + id;
    axios.get(api).then(response => {
      this.setState({ oc: response.data });
      console.log(response);
      console.log(this.state.oc);
      console.log(this.state.oc.ocRef);
    });
  }
  render() {
    console.log(!!this.setState.oc);
    const oc = this.setState.oc ? (
      <div className="post">
        baba
        <h4 className="center">{this.state.oc.ocRef}</h4>
        <p>{this.state.oc.ocRef}</p>
      </div>
    ) : (
      <div className="center">Loading post...</div>
    );
    return <div className="container">{oc}</div>;
  }
}

export default Oc;
