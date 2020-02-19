import React from 'react';

const OcComponent = ({ ocs }) => {
  const ocList = ocs.map(oc => {
    return (
      <div className="" key={oc.id}>
        <div>oc id: {oc.id}</div>
        <div>oc ref: {oc.ocRef}</div>
        <div>oc name: {oc.name}</div>
      </div>
    );
  });
  return <div className="oc-list">{ocList}</div>;
};

export default OcComponent;
