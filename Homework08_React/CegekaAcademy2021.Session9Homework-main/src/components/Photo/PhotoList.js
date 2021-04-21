import React from 'react' ; 
import PropTypes from 'prop-types'
import {Card,Button, Icon} from 'semantic-ui-react'
import StatusBar from '../StatusBar/StatusBar' ; 
import { DeleteButton} from '../Common';
import PhotoForm from '../Photo/PhotoForm' ; 
import Photo from '../Photo/Photo' ; 
import { connect } from 'react-redux';
import * as photoActions from '../../actions/photoActions';
const PhotoList= (props) =>{
    const {photos, deletePhoto, editPhoto, createPhoto} = props ; 
    console.log(props) ; 
    const renderPhotos = ()=> {
        return (
            Object.keys(photos).map(key => {
                const photo = photos[key] ;
                return (
                <Photo 
                key={key}
                photo={photo}
                >
                    <PhotoForm
                        formType= 'Edit'
                        index={key}
                        photo={photo}
                        editPhoto={editPhoto}>
                    </PhotoForm>
                    <DeleteButton 
                        index={key}
                        objectName={photo.title}
                        deleteObject={deletePhoto}>
                    </DeleteButton>
                </Photo>               
                )
            })
        )
    }
    return (
        <div>
            <StatusBar title= {`${Object.keys(photos).length} Photo(s) total`}>
                <PhotoForm
                formType= 'New'
                photos = {photos}
                createPhoto={createPhoto}>                   
                </PhotoForm>
                </StatusBar>
                <Card.Group itemsPerRow = {4} doubling>
                    {renderPhotos()}
                </Card.Group>
        </div>
    )
    
}
PhotoList.propTypes ={
    photos: PropTypes.object.isRequired,
    deletePhoto: PropTypes.func.isRequired,
    editPhoto: PropTypes.func.isRequired,
    createPhoto: PropTypes.func.isRequired,
}; 
const mapStateToProps = (state) => {
    return {
      photos: state.photos,
    }
  }
  
  function mapDispatchToProps(dispatch) {
    return {
      deletePhoto: key => dispatch(photoActions.deletePhoto(key)),
    }
  }
  
  export default connect(mapStateToProps, mapDispatchToProps)(PhotoList);