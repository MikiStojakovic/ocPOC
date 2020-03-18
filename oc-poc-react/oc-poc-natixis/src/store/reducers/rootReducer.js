import authReducer from './authReducer';
import ocReducer from './ocReducer';
import { combineReducers } from 'redux';
import { firestoreReducer } from 'redux-firestore';

const rootReducer = combineReducers({
  auth: authReducer,
  oc: ocReducer,
  firestore: firestoreReducer
});

export default rootReducer;
