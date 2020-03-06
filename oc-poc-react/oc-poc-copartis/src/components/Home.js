import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import Pokeball from '../pokeball.png';
import { connect } from 'react-redux';
import { loadOcs } from '../actions/ocActions';

class Home extends Component {
  componentDidMount() {
    this.props.loadOcs();
  }

  render() {
    const ocs = this.props.ocs;
    const ocsList = ocs.length ? (
      ocs.map(oc => {
        return (
          <div className="post card" key={oc.id}>
            <img src={Pokeball} alt="oc" />
            <div className="card-content">
              <Link to={'/' + oc.id}>
                <span className="card-title red-text">{oc.ocRef}</span>
              </Link>
              <p>{oc.propertyOne}</p>
            </div>
          </div>
        );
      })
    ) : (
      <div className="center">No ocs yet</div>
    );
    return (
      <div className="container home">
        <h1 className="center blue-text">Ouverture compte - home</h1>
        {ocsList}
      </div>
    );
  }
}

const mapStateToProps = state => {
  return {
    ocs: state.ocs
  };
};

const mapDispatchToProps = dispatch => {
  return {
    loadOcs: () => {
      dispatch(loadOcs());
    }
  };
};

export default connect(mapStateToProps, mapDispatchToProps)(Home);
