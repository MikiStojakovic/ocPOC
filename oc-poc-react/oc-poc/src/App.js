import React, { Component } from 'react';
import OcComponent from './OcComponent';

class App extends Component {
  state = {
    ocs: [
      { id: 1, ocRef: 'ref 1', name: 'oc 1' },
      { id: 2, ocRef: 'ref 2', name: 'oc 2' },
      { id: 3, ocRef: 'ref 3', name: 'oc 3' }
    ]
  };

  render() {
    return (
      <div className="App">
        <h1>My first React app!</h1>
        <p>Welcome ;)</p>
        <OcComponent ocs={this.state.ocs} />
      </div>
    );
  }
}

export default App;
