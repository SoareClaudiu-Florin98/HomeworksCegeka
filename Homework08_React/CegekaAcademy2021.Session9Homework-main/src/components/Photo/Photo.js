import React from 'react';
import PropTypes from 'prop-types' ; 
import {Card , Icon, Image, Label, Button} from 'semantic-ui-react' ; 



const Photo = (props) => {
    const {photo} = props ; 

return (
    <Card>
        <Card.Content className="header">
            <Card.Content className="photo-container">
                <Image  src ={photo.url}>
                </Image>
            </Card.Content>
            <Card.Content >
            <Card.Header as ="h3">
                {photo.title}
            </Card.Header>
            </Card.Content>
            <Card.Content>
                <Card.Description as = "p">
                    {photo.description}
                </Card.Description>
            </Card.Content>
        </Card.Content>
        <Button.Group basic attached = 'bottom'>
            {props.children}
        </Button.Group>


    </Card>
)}
Photo.propTypes = {
    photo : PropTypes.object.isRequired,   
}
export default Photo ; 