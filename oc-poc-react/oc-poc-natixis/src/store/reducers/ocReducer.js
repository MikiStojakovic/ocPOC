import { Switch } from 'react-router-dom';

const initState = {
  ocs: [
    { id: 1, ocRef: 'ref 1', modeSoummision: 'Electronic' },
    { id: 2, ocRef: 'ref 2', modeSoummision: 'Semi Electronic' },
    { id: 3, ocRef: 'ref 3', modeSoummision: 'Manual' }
  ]
};

const ocReducer = (state = initState, action) => {
  switch (action.type) {
    case 'CREATE_OC':
      console.log('created oc', action.oc);
      return state;
    case 'CREATE_OC_ERROR':
      console.log('create oc error', action.er);
      return state;
    default:
      return state;
  }
};

export default ocReducer;
