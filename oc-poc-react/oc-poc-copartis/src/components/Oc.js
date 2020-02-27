import React, { Component } from 'react';
import axios from 'axios';
import { connect } from 'react-redux';

class Oc extends Component {
  handleClick = () => {
    this.props.deleteOc(this.props.oc.id);
    this.props.history.push('/');
  };
  // state = {
  //   oc: null
  // };
  // componentDidMount() {
  //   console.log('start componentDidMount');
  //   let id = this.props.match.params.id;
  //   let api = 'http://localhost:54188/api/oc/' + id;
  //   axios.get(api).then(response => {
  //     this.setState({ oc: response.data });
  //   });
  // }
  render() {
    console.log('opened oc');
    console.log(this.props);
    const oc = this.props ? (
      <div className="post">
        <h4 className="center">Oc reference: {this.props.oc.ocRef}</h4>
        <p>Description: {this.props.oc.ocRef}</p>
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
  let id = ownProps.match.params.id;
  return {
    oc: state.ocs.find(oc => oc.id == id)
  };
};

const mapDispatchToProps = dispatch => {
  return {
    deleteOc: id => {
      dispatch({ type: 'DELETE_OC', id: id });
    }
  };
};

export default connect(mapStateToProps, mapDispatchToProps)(Oc);
