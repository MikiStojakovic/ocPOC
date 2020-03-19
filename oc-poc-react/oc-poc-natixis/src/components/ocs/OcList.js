import React from 'react';
import OcSummary from './OcSummary';
import { Link } from 'react-router-dom';

const OcList = ({ ocs }) => {
  return (
    <div className="oc-list section">
      {ocs &&
        ocs.map(oc => {
          return (
            <Link to={'/oc/' + oc.id}>
              <OcSummary oc={oc} key={oc.id} />
            </Link>
          );
        })}
    </div>
  );
};

export default OcList;
