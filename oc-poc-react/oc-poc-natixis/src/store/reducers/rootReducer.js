import authReducer from './authReducer';
import ocReducer from './ocReducer';
import { combineReducers } from 'redux';

const rootReducer = combineReducers({
  auth: authReducer,
  oc: ocReducer
});

export default rootReducer;
