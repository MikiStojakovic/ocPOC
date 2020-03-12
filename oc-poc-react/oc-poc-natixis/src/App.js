import React, { Component } from 'react';
import { BrowserRouter as BRouter, Switch, Route } from 'react-router-dom';
import { render } from '@testing-library/react';
import Navbar from './components/layout/Navbar';
import Dashboard from './components/dashboard/Dashboard';
import OcDetails from './components/ocs/OcDetails';
import SignIn from './components/auth/SingIn';
import SignUp from './components/auth/SignUp';

class App extends Component {
  render() {
    return (
      <BRouter>
        <div className="App">
          <Navbar />
          <Switch>
            <Route exact path="/" component={Dashboard} />
            <Route path="/oc/:id" component={OcDetails} />
            <Route path="/signin" component={SignIn} />
            <Route path="/signup" component={SignUp} />
          </Switch>
        </div>
      </BRouter>
    );
  }
}

export default App;
