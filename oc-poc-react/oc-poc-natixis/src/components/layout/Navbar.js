import React from 'react';
import { Link } from 'react-router-dom';
import SignedInLinks from './SignedInLinks';
import SignedOutLinks from './SignedOutLinks';
import { connect } from 'react-redux';

const Navbar = () => {
  return (
    <nav className="nav-wrapper grey darken-3">
      <div className="container">
        <Link to="/" className="brand-logo">
          Natixis
        </Link>
        <SignedInLinks />
        <SignedOutLinks />
      </div>
    </nav>
  );
};

const mapStateToProps = state => {
  console.log(state);
  return {};
};

export default connect(mapStateToProps)(Navbar);

// export default compose(
//   firestoreConnect(),
//   firestoreConnect(props => {
//     return [{ collection: 'ocs', doc: props.match.params.id }];
//   }),
//   connect(mapStateToProps)
// )(OcDetails);
