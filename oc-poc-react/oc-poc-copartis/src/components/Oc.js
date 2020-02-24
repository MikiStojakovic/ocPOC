import React, { Component } from 'react';

class Oc extends Component {
  state = {
    id: null
  };
  componentDidMount() {
    let id = this.props.match.params.id;
    console.log(this.props);
    this.setState({
      id: id
    });
  }
  render() {
    return (
      <div className="container">
        <h4>{this.state.id}</h4>
      </div>
    );
  }
}

export default Oc;
