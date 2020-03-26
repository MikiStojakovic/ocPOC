import React from 'react';

const OcSummary = ({ oc }) => {
  return (
    <div className="card z-depth-0 project-summary">
      <div className="card-content grey-text text-darken-3">
        <span className="card-title">{oc.ocRef}</span>
        <p>
          Created by {oc.conseillerFirstName} {oc.conseillerLastName}
        </p>
        <p className="grey-text">
          {oc.createdAt ? oc.createdAt.toDate().toString() : null}
        </p>
      </div>
    </div>
  );
};

export default OcSummary;
