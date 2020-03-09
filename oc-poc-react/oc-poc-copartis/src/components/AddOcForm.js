import React, { Component } from 'react';
import { connect } from 'react-redux';
import { createOc, updateOc } from '../actions/ocActions';
import { Link, useParams } from 'react-router-dom';

class AddOcForm extends Component {
  // state = {
  //   oc: { Id: '', OcRef: '', PropertyOne: '' }
  // };

  handleChange = e => {
    this.setState({
      oc: {
        Id: document.getElementById('Id').value,
        OcRef: document.getElementById('OcRef').value,
        PropertyOne: document.getElementById('PropertyOne').value
      }
    });
  };

  handleCreate = e => {
    e.preventDefault();
    let oc = {
      Id: +this.state.oc.Id,
      OcRef: this.state.oc.OcRef,
      PropertyOne: this.state.oc.PropertyOne
    };
    this.props.createOc(oc);
  };

  handleUpdate = () => {
    this.props.updateOc(this.props.oc);
    this.props.history.push('/');
  };

  componentDidMount(ownProps) {
    let id = this.oc.id;
    console.log(id);
    // this.props.getOcById(id);
  }

  render() {
    return (
      <div className="container">
        <form onSubmit={this.handleSubmit} className="white">
          <h5 className="grey-text text-darken-3">
            Create/Update Ouverture Compte
          </h5>
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
            <div className="center">
              <div className="btn gray" onClick={this.handleCreate}>
                Create OC
              </div>
              <div className="btn gray" onClick={this.handleUpdate}>
                Update OC
              </div>
            </div>
          </div>
        </form>
      </div>
    );
  }
}

const mapStateToProps = (state, ownProps) => {
  return {
    oc: state.oc
  };
};

const mapDispatchToProps = dispatch => {
  return {
    createOc: oc => {
      dispatch(createOc(oc));
    },
    updateOc: oc => {
      dispatch(updateOc(oc));
    }
  };
};

export default connect(mapStateToProps, mapDispatchToProps)(AddOcForm);
