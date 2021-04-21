import React from "react";
import {Switch, Route } from  'react-router-dom'; 
import * as api from '../../api' ; 
import AlbumList from '../Album/AlbumList'; 
import PhotoList from '../Photo/PhotoList'; 
import Login from '../Login/Login' ; 
import {Message} from 'semantic-ui-react' ;
class Main extends React.Component {
    renderError() {
      return (
        <Message
          icon="warning circle"
          header="Ups... Page Not Found"
          content="Our engineers didn't found what your are looking for, please try again!"
        />
      );
    }
  
    render() {
      return (
        <Switch>
          <Route exact path="/" component={Login} />
          <Route path="/albums" component={AlbumList} />
          <Route path="/photos" component={PhotoList} />
          <Route path="/login" component={Login} />
          <Route render={this.renderError} />
        </Switch>
      );
    }
  }
  
  export default Main;