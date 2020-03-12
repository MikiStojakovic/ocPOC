import React, { Component } from 'react';
import { BrowserRouter as BRouter } from 'react-router-dom';
import { render } from '@testing-library/react';
import Navbar from './components/layout/Navbar';

class App extends Component {
  render() {
    return (
      <BRouter>
        <div className="App">
          <Navbar />
        </div>
      </BRouter>
    );
  }
}

export default App;
