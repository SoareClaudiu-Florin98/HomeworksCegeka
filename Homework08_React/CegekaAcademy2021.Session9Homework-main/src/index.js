import React from 'react';
import ReactDOM from 'react-dom';
import App from './components/App';
import registerServiceWorker from './registerServiceWorker';
import 'semantic-ui-css/semantic.min.css';
import {Switch, Route , BrowserRouter} from  'react-router-dom'; 


ReactDOM.render(
  <BrowserRouter>
  <App />
  </BrowserRouter>
, document.getElementById('root'));

registerServiceWorker();
