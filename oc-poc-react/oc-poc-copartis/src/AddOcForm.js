import React, { Component } from 'react';

class AddOcForm extends Component {
  state = {
    oc: { id: '', name: '', ref: '', fournissier: '' }
  };

  handleChange = e => {
    this.setState({
      oc: {
        id: '4',
        name: e.target.value,
        ref: 'ref-4',
        fournissier: 'copartis'
      }
    });
  };

  handleSubmit = e => {
    e.preventDefault();
    this.props.addOc(this.state.oc);
    this.setState({
      oc: { id: '', name: '', ref: '', fournissier: '' }
    });
  };

  render() {
    return (
      <div>
        <form onSubmit={this.handleSubmit}>
          <label>Add new oc</label>
          <input
            type="text"
            onChange={this.handleChange}
            value={this.state.oc.name}
          ></input>
        </form>
      </div>
    );
  }
}

export default AddOcForm;
