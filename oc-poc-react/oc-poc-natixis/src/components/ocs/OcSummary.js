import React from 'react';
import moment from 'moment';

const OcSummary = ({ oc }) => {
  return (
    <div className="card z-depth-0 project-summary">
      <div className="card-content grey-text text-darken-3">
        <span className="card-title">{oc.ocRef}</span>
        <p>
          Created by {oc.conseillerFirstName} {oc.conseillerLastName}
        </p>
        <p className="grey-text">
          {oc.createdAt ? moment(oc.createdAt.toDate()).calendar() : null}
        </p>
      </div>
    </div>
  );
};

export default OcSummary;
