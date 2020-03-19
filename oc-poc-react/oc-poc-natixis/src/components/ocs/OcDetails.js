import React from 'react';
import { connect } from 'react-redux';
import { firestoreConnect } from 'react-redux-firebase';
import { compose } from 'redux';

const OcDetails = props => {
  const { oc } = props;
  console.log(oc);
  if (oc) {
    return (
      <div className="container section oc-detail">
        <div className="car z-depth-0">
          <div className="card-content">
            <label>Oc Reference</label>
            <div className="card-title">{oc.ocRef}</div>
            <label>Mode soumission</label>
            <div className="card-action gret lighten-4 grey-text">
              {oc.modeSoumission}
            </div>
            <div>
              <label>Posted by</label>
              <div className="card-action gret lighten-4 grey-text">
                <div>
                  {oc.conseillerFirstName} {oc.conseillerLastName}
                </div>
                <div>12th March, 2pm</div>
              </div>
            </div>
          </div>
        </div>
      </div>
    );
  } else {
    return (
      <div className="container center">
        <p>Loading ocs..</p>
      </div>
    );
  }
};

const mapStateToProps = (state, ownProps) => {
  let oc;
  if (state.firestore.data && state.firestore.data.ocs) {
    oc = state.firestore.data.ocs[ownProps.match.params.id];
  }

  return {
    oc: oc
  };
};

export default compose(
  firestoreConnect(),
  firestoreConnect(props => {
    return [{ collection: 'ocs', doc: props.match.params.id }];
  }),
  connect(mapStateToProps)
)(OcDetails);
