import React from 'react' ; 
import PropTypes from 'prop-types' ; 
import {Grid, Segment} from 'semantic-ui-react' ; 

const StatusBar = (props) => {
    return(
        <Grid columns = {2} className = 'status-bar'>
            <Grid.Column>
                <Segment basic>
                    {props.title}
                </Segment>
            </Grid.Column>
            <Grid.Column textAlign = 'right'>
                <Segment basic>
                    {props.children}
                </Segment>
            </Grid.Column>
        </Grid>
    ); 
}
StatusBar.propTypes ={
    title: PropTypes.string.isRequired
}
export default  StatusBar ; 