import React, { Component } from 'react';
import OcComponent from './OcComponent';
import AddOc from './AddOc';

class App extends Component {
  state = {
    ocs: [
      { id: 1, ocRef: 'ref 1', name: 'oc 1' },
      { id: 2, ocRef: 'ref 2', name: 'oc 2' },
      { id: 3, ocRef: 'ref 3', name: 'oc 3' }
    ]
  };

  addOc = oc => {
    let ocs = [...this.state.ocs, oc];
    this.setState({
      ocs: ocs
    });
  };

  deleteOc = id => {
    let ocs = this.state.ocs.filter(oc => oc.id !== id);
    this.setState({
      ocs: ocs
    });
  };

  render() {
    return (
      <div className="App">
        <h1>My first React app!</h1>
        <p>Welcome ;)</p>
        <OcComponent deleteOc={this.deleteOc} ocs={this.state.ocs} />
        <AddOc addOc={this.addOc} />
      </div>
    );
  }
}

export default App;
