import React from 'react';

const OcsList = ({ ocs, deleteOc }) => {
  const ocList = null;
  //ocs.length ?
  //(
  // ocs.map(oc => {
  //   return (
  //     <div className="collection-item" key={oc.id}>
  //       <span
  //         onClick={() => {
  //           deleteOc(oc.id);
  //         }}
  //       >
  //         {oc.name}
  //       </span>
  //     </div>
  //   );
  //})
  //) : (
  // <p className="center">You don't have and occ</p>
  //);
  return (
    <div>
      <label>OC list</label>
      <div className="ocs collection">{ocList}</div>
    </div>
  );
};

export default OcsList;
