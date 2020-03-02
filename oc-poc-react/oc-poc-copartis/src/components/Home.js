import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import Pokeball from '../pokeball.png';
import { connect } from 'react-redux';
import { loadOcs } from '../actions/ocActions';

class Home extends Component {
  loadOcs = () => {
    let result = this.props.loadOcs();
    return result;
    // this.props.deleteOc(this.props.oc.id);
    // this.props.history.push('/');
  };
  // state = {
  //   ocs: []
  // };
  componentDidMount() {
    console.log(this.loadOcs());
  }
  render() {
    const { ocs } = this.props;
    const ocsList = ocs.length ? (
      ocs.map(oc => {
        console.log(oc);
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
