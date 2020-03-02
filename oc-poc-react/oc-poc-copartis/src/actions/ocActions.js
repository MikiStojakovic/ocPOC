import axios from 'axios';

export const loadOcs = () => {
  return {
    type: 'GET_ALL_OCS',
    execute: () => {
      axios.get('http://localhost:54188/api/oc').then(respone => {
        return respone;
      });
    }
  };
  // return dispatch => {
  //   return axios.get('http://localhost:54188/api/oc').then(respone => {
  //     return respone;
  //   });
  // };
};

export const deleteOc = id => {
  return {
    type: 'DELETE_OC',
    id
  };
};
