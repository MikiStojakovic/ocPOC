import axios from 'axios';

const initState = {
  ocs: [
    { id: 1, ocRef: 'ocRef 1' },
    { id: 2, ocRef: 'ocRef 2' }
  ]
};

// const getOcs = () => {
//   axios.get('http://localhost:54188/api/oc').then(response => {
//     console.log(response.data);
//   });
// };
// getOcs();

const rootReducer = (state = initState, action) => {
  return state;
};

export default rootReducer;
