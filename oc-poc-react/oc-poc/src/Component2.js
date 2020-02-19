import React, { Component } from 'react';

class Component2 extends Component {
  render() {
    const { name, id, ocRef } = this.props;
    return (
      <div>
        <div>oc id: {id}</div>
        <div>oc ref: {ocRef}</div>
        <div>oc name: {name}</div>
      </div>
    );
  }
}

export default Component2;
