import React, { Component } from 'react';
import Home from './components/Home';
import OcsList from './components/OcsList';
import AddOcForm from './components/AddOcForm';
import Navbar from './components/Navbar';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import Oc from './components/Oc';

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
      <BrowserRouter>
        <div className="oc-app container">
          <Navbar />
          <Switch>
            <Route exact path="/" component={Home} />
            <Route path="/ocList" component={OcsList} />
            <Route path="/addOc" component={AddOcForm} />
            <Route path="/:id" component={Oc} />
          </Switch>
          {/* <h1 className="center blue-text">Ouverture compte</h1>
          <OcsList ocs={this.state.ocs} deleteOc={this.deleteOc} />
          <AddOcForm addOc={this.addOc} /> */}
        </div>
      </BrowserRouter>
    );
  }
}

export default App;
