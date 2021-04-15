import React from 'react';
import { PhotoForm } from './PhotoForm';
import { Button } from 'semantic-ui-react'

const setup = ( formType ) => {
  const props = {
    formType,
    key: 'photo1',
    photo: { 
      "title": "Fright Night Part II",
      "description": "Nunc rhoncus dui vel sem.",
      "url": "https://source.unsplash.com/1600x900/?happy"
    },
    updatePhoto: jest.fn(),
    createPhoto: jest.fn(),
  }

  const component = shallow(<PhotoForm {...props} />); 

  return {
    component,
    props,
    modalButton: component.find(Button).first(),
    saveButton: component.find(Button).last(),
  }
}

describe('PhotoForm', () => {

  describe('New Form', () => {
    const { component } = setup('New');
    it('should render without crash', () => {
      expect(component);
    });
  });

});