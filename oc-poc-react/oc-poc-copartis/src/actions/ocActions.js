import axios from 'axios';

export const createOc = oc => {
  return (dispatch, getState) => {
    return axios({
      method: 'post',
      url: 'http://localhost:54188/api/oc',
      data: oc
    }).then(respone => {
      dispatch({ type: 'CREATE_OC', oc: oc });
    });
  };
};

export const loadOcs = () => {
  return dispatch => {
    return axios.get('http://localhost:54188/api/oc').then(respone => {
      dispatch({
        type: 'GET_ALL_OCS',
        ocs: respone.data
      });
    });
  };
};

export const deleteOc = id => {
  return {
    type: 'DELETE_OC',
    id
  };
};
