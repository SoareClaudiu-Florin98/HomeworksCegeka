import* as actionTypes from "../actions/actionTypes";
switch(action.type) {
    case actionTypes.UPDATE_ALBUM :{
        return {
            ...state,
            [action.key]: action.updatedAlbum
        }

    }
    case actionTypes.DELETE_ALBUM :{
        let {[action.key]: albumDeleted, ...restOfAlbums} = state ; 
        return restOfAlbums ; 
    }
    case actionTypes.ADD_ALBUM :{
        return {
            [action.key]: action.album,
            ...state           
        }       
    }
    default: 
        return state ;


}