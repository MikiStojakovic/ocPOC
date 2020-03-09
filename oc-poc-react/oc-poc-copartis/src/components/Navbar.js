import React from 'react';
import { Link, NavLink, Switch, Route } from 'react-router-dom';

const Navbar = () => {
  return (
    <nav className="nav-wrapper red darken-3">
      <div className="container">
        <a href="#" className="brand-logo">
          OC Copartis
        </a>
        <ul className="right">
          {/* <li>
            <Link to="/">Home</Link>
          </li>
          <li>
            <NavLink to="/ocList">OC list</NavLink>
          </li>
          <li>
            <NavLink to="addOc/:id?">Add new oc</NavLink>
          </li> */}
          <Switch>
            <Route path="/" exact>
              Home
            </Route>
            <Route path="/ocList">OC list</Route>
            <Route path="/addOc/:id">Add new oc</Route>
          </Switch>
        </ul>
      </div>
    </nav>
  );
};

export default Navbar;
