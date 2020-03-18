import React, { Components, Component } from 'react';
import Notifications from './Notifications';
import OcList from '../ocs/OcList';
import { connect } from 'react-redux';
import { compose } from 'redux';
import { firestoreConnect } from 'react-redux-firebase';

class Dashboard extends Component {
  render() {
    const { ocs } = this.props;
    return (
      <div className="dashboard container">
        <div className="row">
          <div className="col s12 m6">
            <OcList ocs={ocs} />
          </div>
          <div className="col s12 m5 offset-m1">
            <Notifications />
          </div>
        </div>
      </div>
    );
  }
}

const mapStateToProps = state => {
  console.log(state);
  return {
    ocs: state.firestore.ordered.ocs
  };
};

export default compose(
  firestoreConnect(['ocs']),
  connect(mapStateToProps)
)(Dashboard);
