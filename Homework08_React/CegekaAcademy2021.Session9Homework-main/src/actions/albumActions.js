import * as actionTypes from "./actionTypes";
export const  createAlbum = (album) => {
    const key = `album-${timestamp}` ; 
    return {
        type: actionTypes.ADD_ALBUM,
        album,
        key
    }
}
export const editAlbum = (key, updateAlbum) => ({

  type: actionTypes.UPDATE_ALBUM,
  key,
  updateAlbum
})
deleteAlbum = (key) => ({
    type: actionTypes.DELETE_ALBUM,
    key

})