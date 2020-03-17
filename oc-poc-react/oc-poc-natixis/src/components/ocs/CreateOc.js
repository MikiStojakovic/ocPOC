import React, { Component } from 'react';
import { connect } from 'react-redux';
import { createOc } from '../../store/actions/ocActions';

class CreateOc extends Component {
  state = {
    id: 0,
    ocRef: '',
    modeSoumission: ''
  };

  handleChange = e => {
    this.setState({
      [e.target.id]: e.target.value
    });
  };

  handleSubmit = e => {
    e.preventDefault();
    this.props.createOc(this.state);
  };

  render() {
    return (
      <div className="container">
        <form onSubmit={this.handleSubmit} className="white">
          <h5 className="grey-text text-darken-3">Create Ouverture Compte</h5>
          <div className="input-field">
            <label htmlFor="id">Id</label>
            <input type="text" id="id" onChange={this.handleChange} />
          </div>
          <div className="input-field">
            <label htmlFor="ocRef">OC Reference</label>
            <input type="text" id="ocRef" onChange={this.handleChange} />
          </div>
          <div className="input-field">
            <label htmlFor="modeSoumission">Mode Soumission</label>
            <input
              type="text"
              id="modeSoumission"
              onChange={this.handleChange}
            />
          </div>
          <div className="input-field">
            <button className="btn pink lighten-1 z-depth-0">Create OC</button>
          </div>
        </form>
      </div>
    );
  }
}

const mapDispatchToProps = dispatch => {
  return {
    createOc: oc => dispatch(createOc(oc))
  };
};

export default connect(null, mapDispatchToProps)(CreateOc);
