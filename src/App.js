import React from 'react';
import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';

import Button from 'react-bootstrap/Button'
import { Home } from './Components/Home'
import  Login  from './Components/Login'
import { BrowserRouter as Router ,Switch, Route } from 'react-router-dom'
//import Test from './Components/Test';
class App extends Component {
  constructor(props) {
    super(props)
  }
  render() {
    return (
      <Router>
        <Switch>
          <Route path='/' component={Login} exact />
          <Route path='/login' component={Login} />
          <Route path='/home' component={Home} />
        </Switch>
      </Router>
    );
  }
}

export default App;
