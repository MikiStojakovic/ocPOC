import React, { Component } from 'react';
import { BrowserRouter as BRouter } from 'react-router-dom';
import { render } from '@testing-library/react';

class App extends Component {
  render() {
    return (
      <BRouter>
        <div className="App"></div>
      </BRouter>
    );
  }
}

export default App;
