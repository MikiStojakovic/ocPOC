import React, { Component } from 'react';
import Component2 from './Component2';

function App() {
  return (
    <div className="App">
      <h1>My first React app!</h1>
      <p>Welcome ;)</p>
      <Component2 name="oc1" id="1" ocRef="ref1" />
    </div>
  );
}

export default App;
