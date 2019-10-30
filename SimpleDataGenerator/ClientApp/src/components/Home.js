import React, { Component } from 'react';
import {ButtonToolbar, Button,Jumbotron} from 'react-bootstrap';
import 'bootstrap/dist/css/bootstrap.min.css';

export class Home extends Component {
  displayName = Home.name

  render() {
    return (
      <div>
       <Jumbotron>
  <h1>Welcome!</h1>
  <p>
    This is a simple web application that letys you create random data for testing purposes.
    Completely free to use
  </p>
  <p>
    <Button bsStyle="primary">More..</Button>
  </p>
</Jumbotron>;
      </div>
    );
  }
}
