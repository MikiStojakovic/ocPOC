import React, { Component } from 'react';

class AddOc extends Component {
  state = {
    id: null,
    name: null,
    ref: null
  };

  handleChange = e => {
    this.setState({
      [e.target.id]: e.target.value
    });
  };

  handleSubmit = e => {
    e.preventDefault();
    this.props.addOc(this.state);
  };

  render() {
    return (
      <div>
        <form onSubmit={this.handleSubmit}>
          <label htmlFor="id">Id</label>
          <input type="text" id="id" onChange={this.handleChange} />
          <label htmlFor="name">Name</label>
          <input type="text" id="name" onChange={this.handleChange} />
          <label htmlFor="ref">Reference</label>
          <input type="text" id="ref" onChange={this.handleChange} />
          <button>Submit</button>
        </form>
      </div>
    );
  }
}

export default AddOc;
