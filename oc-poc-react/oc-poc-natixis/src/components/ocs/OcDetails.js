import React from 'react';

const OcDetails = props => {
  const id = props.match.params.id;
  return (
    <div className="container section oc-detail">
      <div className="car z-depth-0">
        <div className="card-content">
          <span className="card-title">Oc Title - {id}</span>
          <p>some text about oc</p>
          <div>
            <div className="card-action gret lighten-4 grey-text">
              <div>Posted by MS Conseiller</div>
              <div>12th March, 2pm</div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default OcDetails;
