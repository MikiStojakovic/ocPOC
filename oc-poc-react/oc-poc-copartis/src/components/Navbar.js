import React from 'react';
import { Link, NavLink } from 'react-router-dom';

const Navbar = () => {
  return (
    <nav className="nav-wrapper red darken-3">
      <div className="container">
        <a className="brand-logo">OC Copartis</a>
        <ul className="right">
          <li>
            <Link to="/">Home</Link>
          </li>
          <li>
            <NavLink to="/ocList">OC list</NavLink>
          </li>
          <li>
            <NavLink to="addOc">Add new oc</NavLink>
          </li>
        </ul>
      </div>
    </nav>
  );
};

export default Navbar;
