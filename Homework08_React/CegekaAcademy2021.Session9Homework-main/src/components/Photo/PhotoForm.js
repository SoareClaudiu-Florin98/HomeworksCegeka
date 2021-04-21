import React from 'react' ; 
import PropTypes from 'prop-types';
import {Modal, Form, Button, Icon, Message} from 'semantic-ui-react';
import { connect } from 'react-redux';
import * as photoActions from '../../actions/photoActions';
class PhotoForm extends React.Component {
    state = {
        error: false,
        modalOpen:false,
        photo: {
            title: '',
            description: '',
            url:''
        }
    }
    handleInputChange = (name,value) => {
        const {photo} = this.state; 
        const updatePhotos = {
            ...photo, 
            [name]:value
        }
        this.setState({
            photo: updatePhotos
        })        
    }
    isFormValid = () => {
        const {photo}= this.state ; 
        if( !photo) return false;
        else if(!photo.title) return false;
        else if(!photo.description) return false;
        else if(!photo.url) return false;

        return true ; 
    }
    handleSubmit = (e) => {
        if(!this.isFormValid()){
            this.setState ({error: true}) ; 
            return ; 
        }
        this.setState({ error: false}) ; 
        const {updatePhoto, createPhoto, index}= this.props ; 
        const {photo} = this.state ; 
        if( this.isNewForm()){
            createPhoto(photo) ; 
        }else{
            updatePhoto(index,photo); 
        }
        this.closeForm() ; 

    }
    showForm = () =>{
        const {photo}= this.props ; 
        this.setState({
            modalOpen : true,
            photo,
        })
    }
    closeForm = () =>this.setState({modalOpen:false});
    isNewForm= () => this.props.formType === 'New';

    render(){
        const {modalOpen,photo,error}= this.state ; 
        return(<Modal className="myModal"
            trigger={
            <Button icon onClick={this.showForm}>
                <Icon name={this.isNewForm()?'plus':'pencil alternate'} />
            </Button>        
        }
        centered={true}
        size= 'small'
        closeIcon
        open = {modalOpen}
        onClose = {this.closeForm}>
            <Modal.Header>
                {this.isNewForm()?'Create Photo': `Edit: ${photo.title}`}
            </Modal.Header>
            <Modal.Content>
                <Form error={error}>
                    <Message
                    error
                    content = 'Complete all fields..'
                    ></Message>
                    <Form.Input
                    name = "title"
                    label ="Title"
                    placeholder = "Photo title"
                    defaultValue = {this.isNewForm()? '':photo.title}
                    onChange={(e) => this.handleInputChange(e.target.name, e.target.value)}
                    required>
                    </Form.Input>
                    <Form.TextArea
                    name = "description"
                    label = "Description"
                    placeholder = "Tell more about this photo..."
                    defaultValue = {this.isNewForm()? '':photo.description}
                    onChange={(e) => this.handleInputChange(e.target.name, e.target.value)}
                    required>
                    </Form.TextArea>
                    <Form.Input
                    name = "url"
                    label ="URL"
                    placeholder = "url"
                    defaultValue = {this.isNewForm()? '':photo.url}
                    onChange={(e) => this.handleInputChange(e.target.name, e.target.value)}
                    required>
                    </Form.Input>
                </Form>       
            </Modal.Content>
            <Modal.Actions>
                <Button positive icon='save' content='Save' onClick={e =>this.handleSubmit(e)}/>
            </Modal.Actions>
        </Modal>)
    }
    static propTypes ={
        formType : PropTypes.oneOf(['New', 'Edit']).isRequired,
        photo :PropTypes.object.isRequired,
        index : PropTypes.string,
        editPhoto: PropTypes.func,
        createPhoto: PropTypes.func
    }

}
const mapStateToProps = (state) => {
    return {
      photos: state.photos,
    }
  }
  
  const mapDispatchToProps = (dispatch) => {
    return {
      createPhoto: photo => dispatch(photoActions.addPhoto(photo)),
      updatePhoto: (key, photo) => dispatch(photoActions.updatePhoto(key, photo)),
    }
  }
  
export default connect(mapStateToProps, mapDispatchToProps)(PhotoForm);