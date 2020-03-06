import React, { Component } from 'react';
import { connect } from 'react-redux';
import { createOc } from '../actions/ocActions';

class AddOcForm extends Component {
  state = {
    oc: { Id: '', OcRef: '', PropertyOne: '' }
  };

  handleChange = e => {
    this.setState({
      oc: {
        Id: document.getElementById('Id').value,
        OcRef: document.getElementById('OcRef').value,
        PropertyOne: document.getElementById('PropertyOne').value
      }
    });
  };

  handleSubmit = e => {
    e.preventDefault();
    let oc = {
      Id: +this.state.oc.Id,
      OcRef: this.state.oc.OcRef,
      PropertyOne: this.state.oc.PropertyOne
    };
    this.props.createOc(oc);
  };

  render() {
    return (
      <div className="container">
        <form onSubmit={this.handleSubmit} className="white">
          <h5 className="grey-text text-darken-3">Create new project</h5>
          <div className="input-field">
            <label htmlFor="Id">Id</label>
            <br />
            <input type="text" id="Id" onChange={this.handleChange} />
          </div>
          <div className="input-field">
            <label htmlFor="OcRef">Oc Ref</label>
            <br />
            <input type="text" id="OcRef" onChange={this.handleChange} />
          </div>
          <div className="input-field">
            <label htmlFor="PropertyOne">Property One</label>
            <br />
            <input type="text" id="PropertyOne" onChange={this.handleChange} />
            <button onClick={this.handleSubmit}>Submit</button>
          </div>
        </form>
      </div>
    );
  }
}

const mapDispatchToProps = dispatch => {
  return {
    createOc: oc => {
      dispatch(createOc(oc));
    }
  };
};

export default connect(null, mapDispatchToProps)(AddOcForm);
