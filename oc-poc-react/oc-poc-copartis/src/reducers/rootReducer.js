import axios from 'axios';

const initState = {
  ocs: []
};

const rootReducer = (state = initState, action) => {
  if (action.type === 'CREATE_OC') {
    console.log('CREATE_OC');
    console.log(action.oc);
    // return {
    //   ...state,
    //   ocs: []]
    // };
  }
  if (action.type === 'GET_OC_BY_ID') {
    return {
      ...state,
      oc: action.oc
    };
  }
  if (action.type === 'DELETE_OC') {
    let newOcs = state.ocs.filter(oc => {
      return action.id !== oc.id;
    });
    return {
      ...state,
      ocs: newOcs
    };
  }
  if (action.type === 'GET_ALL_OCS') {
    return {
      ...state,
      ocs: action.ocs
    };
  }
  if (action.type === 'DELETE_OC') {
    return {
      ...state
    };
  }
  return state;
};

export default rootReducer;
