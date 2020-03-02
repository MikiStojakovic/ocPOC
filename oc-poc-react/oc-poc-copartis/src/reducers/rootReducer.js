import axios from 'axios';

const initState = {
  ocs: []
};

// const getOcs = () => {
//   axios.get('http://localhost:54188/api/oc').then(response => {
//     console.log(response.data);
//   });
// };
// getOcs();

const rootReducer = (state = initState, action) => {
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
    let ocs = action.ocs;
    console.log('get all ocs');
    console.log(ocs);
    return {
      ...state,
      ocs: ocs
    };
  }
  return state;
};

export default rootReducer;
