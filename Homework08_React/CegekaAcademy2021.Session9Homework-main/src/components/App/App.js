import React from 'react';
import {Main} from '../Main'; 
import {Nav} from '../Nav'; 
import { Provider } from 'react-redux';
import PropTypes from 'prop-types';
import {BrowserRouter} from  'react-router-dom'; 

const App = (props) => {
  return (
    <Provider store={props.store}>
      <BrowserRouter>
        <div>
          <Nav />
          <Main />
        </div>
      </BrowserRouter>
    </Provider>
  );
}
App.propTypes = {
  store: PropTypes.object.isRequired,
}
export default App;
