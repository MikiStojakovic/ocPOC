import authReducer from './authReducer';
import ocReducer from './ocReducer';
import { combineReducers } from 'redux';
import { firestoreReducer } from 'redux-firestore';
import { firebaseReducer } from 'react-redux-firebase';

const rootReducer = combineReducers({
  auth: authReducer,
  oc: ocReducer,
  firestore: firestoreReducer,
  firebase: firebaseReducer
});

export default rootReducer;
