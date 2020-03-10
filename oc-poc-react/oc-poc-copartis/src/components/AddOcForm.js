import React, { Component } from 'react';
import { connect } from 'react-redux';
import { createOc, updateOc, getOcById } from '../actions/ocActions';
import { Link, useParams } from 'react-router-dom';

class AddOcForm extends Component {
  handleChange = e => {
    // this.setState({
    //   props.oc: {
    //     //Id: document.getElementById('Id').value,
    //     ocRef: document.getElementById('OcRef').value,
    //     propertyOne: document.getElementById('PropertyOne').value
    //   }
    // });
    this.props.oc.ocRef = document.getElementById('PropertyOne').value;
    this.props.oc.propertyOne = document.getElementById('PropertyOne').value;
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
    let id = this.props.match.params.id;
    console.log(id);
    this.props.getOcById(id);
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
            <input
              type="text"
              id="Id"
              onChange={this.handleChange}
              value={this.props.oc ? this.props.oc.id : null}
            />
          </div>
          <div className="input-field">
            <label htmlFor="OcRef">Oc Ref</label>
            <br />
            <input
              type="text"
              id="OcRef"
              onChange={this.handleChange}
              value={this.props.oc ? this.props.oc.ocRef : null}
            />
          </div>
          <div className="input-field">
            <label htmlFor="PropertyOne">Property One</label>
            <br />
            <input
              type="text"
              id="PropertyOne"
              onChange={this.handleChange}
              value={this.props.oc ? this.props.oc.propertyOne : null}
            />
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
    },
    getOcById: id => {
      dispatch(getOcById(id));
    }
  };
};

export default connect(mapStateToProps, mapDispatchToProps)(AddOcForm);
