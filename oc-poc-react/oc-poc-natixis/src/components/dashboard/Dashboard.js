import React, { Components, Component } from 'react';
import Notifications from './Notifications';
import OcList from '../ocs/OcList';
import { connect } from 'react-redux';
import { compose } from 'redux';
import { firestoreConnect } from 'react-redux-firebase';
import { Redirect } from 'react-router-dom';

class Dashboard extends Component {
  render() {
    const { ocs, auth, notifications } = this.props;
    console.log(this.props);
    console.log(notifications);

    if (!auth.uid) return <Redirect to="/signin" />;

    return (
      <div className="dashboard container">
        <div className="row">
          <div className="col s12 m6">
            <OcList ocs={ocs} />
          </div>
          <div className="col s12 m5 offset-m1">
            <Notifications notifications={notifications} />
          </div>
        </div>
      </div>
    );
  }
}

const mapStateToProps = state => {
  console.log(state);
  return {
    ocs: state.firestore.ordered.ocs,
    notifications: state.firestore.ordered.notifications,
    auth: state.firebase.auth
  };
};

export default compose(
  connect(mapStateToProps),
  firestoreConnect(props => {
    console.log(props);
    if (!props.auth.uid) return [];

    return [
      {
        collection: 'ocs',
        where: ['authorId', '==', props.auth.uid],
        orderBy: ['createdAt', 'desc']
      },
      { collection: 'notifications', limit: 3, orderBy: ['time', 'desc'] }
    ];
  })
)(Dashboard);
