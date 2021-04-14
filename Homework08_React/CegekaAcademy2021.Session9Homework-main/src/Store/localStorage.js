import * as api  from '../api' ; 

export const loadState = () => {

    const localStorageAlbums = localStorage.getItem('albums') ;
    const localStoragePhotos = localStorage.getItem('photos') ; 
    if(localStorageAlbums && localStoragePhotos){
        return{
        albums : JSON.parse(localStorageAlbums),
        photos : JSON.parse(localStoragePhotos)
        }
        
    }
    return{

        albums: api.getAlbums(),
        photos: api.getPhotos()
    }
        
};
export const saveState = (itemName, state)=>{
    localStorage.setItem(itemName,JSON.stringify(state))
}
