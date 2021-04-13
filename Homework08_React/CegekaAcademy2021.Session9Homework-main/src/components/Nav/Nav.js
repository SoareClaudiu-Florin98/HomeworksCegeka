import React from "react";
import { NavLink ,BrowserRouter as Router,Switch} from "react-router-dom";
import { Header, Menu } from 'semantic-ui-react';
import Main from '../Main/Main' ; 
const menuItems = [
  {
    name: "albums",
    position: null,
  },
  {
    name: "photos",
    position: null,
  },
  {
    name: "login",
    position: "right",
  },
];
class Nav extends React.Component {

  
  randerMenuItems = (item) => {
    return (       
      <Menu.Item
        position={item.position}
        name={item.name}
        key={item.name}        
        as={NavLink}
        exact to={`/${item.name}`}
      />
    );
  };
  render() {
    return (
      <Router>
        <div>     
      <Menu tabular >
        <Menu.Item>
          <Header
            as="h2"
            icon="images"
            floated="right"
            textAlign="center"
            color="blue"
          />
        </Menu.Item>        
        {Object.keys(menuItems).map((item) => {
          return this.randerMenuItems(menuItems[item]);
        })}         
      </Menu> 
      <Main/>  
      </div> 
      </Router>
      
    );
  }
}
export default Nav;
