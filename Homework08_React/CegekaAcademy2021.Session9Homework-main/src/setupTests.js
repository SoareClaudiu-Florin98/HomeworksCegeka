import Enzyme, { shallow, render, mount } from 'enzyme';
import Adapter from 'enzyme-adapter-react-16';
import 'jest-enzyme';
import renderer from 'react-test-renderer';
import LocalStorageTests from './localStorageTests'
Enzyme.configure({ adapter: new Adapter() });
global.shallow = shallow;
global.render = render;
global.mount = mount;
global.localStorage = new LocalStorageTests();
global.renderer = renderer;