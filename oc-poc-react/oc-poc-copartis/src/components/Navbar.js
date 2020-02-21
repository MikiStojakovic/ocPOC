import React from 'react';

const Navbar = () => {
  return (
    <nav className="nav-wrapper red darken-3">
      <div className="container">
        <a className="brand-logo">OC Copartis</a>
        <ul className="right">
          <li>
            <a href="/">Home</a>
          </li>
          <li>
            <a href="/about">OC list</a>
          </li>
          <li>
            <a href="/contact">Add new oc</a>
          </li>
        </ul>
      </div>
    </nav>
  );
};

export default Navbar;
