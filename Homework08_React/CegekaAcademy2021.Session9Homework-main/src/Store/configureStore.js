import {createStore} from 'redux' ; 
import rootReducer from '../reducers';
import {loadState, saveState} from './localStorage';

const configureStore = () => {
    const persistedData = loadState(); 
    const store = createStore(
        rootReducer,
        persistedData,
        window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__()
    );
    store.subscribe(() => {
        const {albums, photos}= store.getState();
        saveState('albums',albums); 
        saveState('photos', photos);
    }) ; 
    return store ;
}
export default configureStore; 