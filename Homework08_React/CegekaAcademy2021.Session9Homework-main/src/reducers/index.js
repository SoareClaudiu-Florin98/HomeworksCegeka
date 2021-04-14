import {combineReducers} from 'redux';
import Albums from './albums';
import photos from './photos';

const rootReducer= combineReducers({
    albums,
    photos
}); 
export default rootReducer ; 