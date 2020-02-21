import React from 'react';

const Ocs = ({ ocs, deleteOc }) => {
  const ocList = ocs.length ? (
    ocs.map(oc => {
      return (
        <div className="collection-item" key={oc.id}>
          <span
            onClick={() => {
              deleteOc(oc.id);
            }}
          >
            {oc.name}
          </span>
        </div>
      );
    })
  ) : (
    <p className="center">You don't have and occ</p>
  );
  return <div className="ocs collection">{ocList}</div>;
};

export default Ocs;
