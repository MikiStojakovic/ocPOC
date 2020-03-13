import React from 'react';
import OcSummary from './OcSummary';

const OcList = ({ ocs }) => {
  return (
    <div className="oc-list section">
      {ocs &&
        ocs.map(oc => {
          return <OcSummary oc={oc} key={oc.id} />;
        })}
    </div>
  );
};

export default OcList;
