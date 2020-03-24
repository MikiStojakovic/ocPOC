import React, { Component } from 'react';
import { connect } from 'react-redux';
import { createOc } from '../../store/actions/ocActions';
import { Redirect } from 'react-router-dom';

class CreateOc extends Component {
  state = {
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
    const { auth } = this.props;
    if (!auth.uid) return <Redirect to="/signin" />;

    return (
      <div className="container">
        <form onSubmit={this.handleSubmit} className="white">
          <h5 className="grey-text text-darken-3">Create Ouverture Compte</h5>
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

const mapStateToProps = state => {
  return {
    auth: state.firebase.auth
  };
};

const mapDispatchToProps = dispatch => {
  return {
    createOc: oc => dispatch(createOc(oc))
  };
};

export default connect(mapStateToProps, mapDispatchToProps)(CreateOc);
