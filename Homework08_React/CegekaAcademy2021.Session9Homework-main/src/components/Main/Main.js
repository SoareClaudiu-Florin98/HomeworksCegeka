import React from "react";
import {Switch, Route , BrowserRouter} from  'react-router-dom'; 
import * as api from '../../api' ; 
import AlbumList from '../Album/AlbumList'; 
import PhotoList from '../Photo/PhotoList'; 
import Login from '../Login/Login' ; 
import {Message} from 'semantic-ui-react' ;
class Main extends React.Component {
    state = {
        albums : {},
        photos: {},
    }
    
    componentWillMount(){
        const localStorageAlbums = localStorage.getItem("albums") ;
        const localStoragePhotos = localStorage.getItem("photos") ; 
        if(localStorageAlbums && localStoragePhotos){
            this.setState({
            albums : JSON.parse(localStorageAlbums),
            photos : JSON.parse(localStoragePhotos)
            }
            );
        }
        else{
            this.setState(
            {
            albums: api.getAlbums(),
            photos: api.getPhotos()}
            );
        }
    }
    componentWillUpdate(nextState){

        localStorage.setItem('photos', JSON.stringify(nextState.photos)) ;
        localStorage.setItem('albums', JSON.stringify(nextState.albums)) ; 
 
    }
    createAlbum = (album) => {
        let albums = this.state.albums; 
        const timestamp = Date.now() ; 
        albums[`album-${timestamp}`] = album ; 
        this.setState({albums}) ; 
    }
    editAlbum = (key, updateAlbums) => {
        let albums = this.state.albums ; 
        albums[key]= updateAlbums; 
        this.setState({albums}) ; 

    }
    deleteAlbum = (key) => {
        let albums = this.state.albums ; 
        delete albums[key];
        this.setstate({albums}) ;
    }
    createPhoto = (photo) => {
        let photos= this.state.photos ; 
        const timestamp = Date.now() ; 
        photos[`photo-${timestamp}`] = photo ; 
        this.setState({photo}) ; 
    }

    editPhoto = (key, updatePhoto) => {
        let photos = this.state.photos ; 
        photos[key]= updatePhoto; 
        this.setState({photos}) ; 
    }
    deletePhoto = (key) => {
        let photos = this.state.photos ; 
        delete photos[key];
        this.setState({photos}) ;
    }
    render(){
        const {albums,photos} = this.state ; 

        const photoList = ()=>{ 

            <PhotoList
            photos ={photos}
            deletePhoto= {this.deletePhoto}
            editPhoto = {this.editPhoto}
            createPhoto= {this.createPhoto}>
            </PhotoList>

        } 

        const albumList = ()=>{ 
            <AlbumList
            albums ={albums}
            photos={photos}
            deleteAlbum= {this.deleteAlbum}
            editAlbum = {this.editAlbum}
            createAlbum = {this.createAlbum}>
            </AlbumList>
        } 
        const error =()=> {
            <Message icon = 'warning circle'
            header = 'Ups...Error' 
            content ='please go back and try again.'>
            </Message>
        }
        
        return(                 
            <Switch>
                <Route exact path="/" >
                <Login/>
                </Route>
                <Route  path="/albums" render = {albumList}/>
                <Route  path="/photos" render = {photoList}/>
                <Route  path="/login" render = {<Login/>}/>
                <Route rander = {error}/>
            </Switch>            
        ) ; 
    }
 }
 export default Main;