import React, { Component } from 'react';
import axios from 'axios';
import { connect } from 'react-redux';
import { deleteOc, getOcById } from '../actions/ocActions';

class Oc extends Component {
  handleClick = () => {
    this.props.deleteOc(this.props.match.params.id);
    this.props.history.push('/');
  };
  componentDidMount(ownProps) {
    let id = this.props.match.params.id;
    console.log('start componentDidMount');
    this.props.getOcById(id);
  }
  render() {
    const oc = this.props.oc ? (
      <div className="post">
        <h4 className="center">Oc reference: {this.props.oc.ocRef}</h4>
        <p>Oc Reference: {this.props.oc.ocRef}</p>
        <p>Property: {this.props.oc.propertyOne}</p>
        <div className="center">
          <div className="btn gray" onClick={this.handleClick}>
            Delete OC
          </div>
        </div>
      </div>
    ) : (
      <div className="center">Loading post...</div>
    );
    return <div className="container">{oc}</div>;
  }
}

const mapStateToProps = (state, ownProps) => {
  return {
    oc: state.oc
  };
};

const mapDispatchToProps = dispatch => {
  return {
    getOcById: id => {
      dispatch(getOcById(id));
    },
    deleteOc: id => {
      dispatch(deleteOc(id));
    }
  };
};

export default connect(mapStateToProps, mapDispatchToProps)(Oc);
