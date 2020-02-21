import React, { Component } from 'react';
import Ocs from './Ocs';
import AddOcForm from './AddOcForm';

class App extends Component {
  state = {
    ocs: [
      { id: 1, name: 'oc-1', ref: 'ref-1', fournissier: 'copartis' },
      { id: 2, name: 'oc-2', ref: 'ref-2', fournissier: 'copartis' }
    ]
  };
  addOc = newOc => {
    let ids = this.state.ocs.map(oc => oc.id);
    newOc.id = Math.max(...ids) + 1;
    let ocs = [...this.state.ocs, newOc];
    this.setState({
      ocs
    });
  };
  deleteOc = id => {
    let ocs = this.state.ocs.filter(oc => oc.id !== id);
    this.setState({
      ocs
    });
  };

  render() {
    return (
      <div className="oc-app container">
        <h1 className="center blue-text">Ouverture compte</h1>
        <Ocs ocs={this.state.ocs} deleteOc={this.deleteOc} />
        <AddOcForm addOc={this.addOc} />
      </div>
    );
  }
}

export default App;
