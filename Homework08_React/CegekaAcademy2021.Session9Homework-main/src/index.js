import React from 'react';
import ReactDOM from 'react-dom';
import App from './components/App';
import 'semantic-ui-css/semantic.min.css';
import {BrowserRouter} from  'react-router-dom'; 
import registerServiceWorker from './registerServiceWorker';
import configureStore from './store/configureStore';
const store = configureStore();

ReactDOM.render(
  <App store={store}/> 
, document.getElementById('root'));

registerServiceWorker();
