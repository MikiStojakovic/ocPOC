import React, { Component } from 'react';

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
    console.log(this.state);
  };

  render() {
    return (
      <div className="container">
        <form onSubmit={this.handleSubmit} className="white">
          <h5 className="grey-text text-darken-3">Create Ouverture Compte</h5>
          <div className="input-field">
            <label htmlFor="id">Id</label>
            <input type="text" id="Id" onChange={this.handleChange} />
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

export default CreateOc;
