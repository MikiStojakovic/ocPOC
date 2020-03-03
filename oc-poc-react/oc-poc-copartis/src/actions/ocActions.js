import axios from 'axios';

export const createOc = oc => {
  return (dispatch, getState) => {
    const params = new URLSearchParams();
    // params.append('Id', oc.Id);
    // params.append('OcRef', oc.OcRef);
    // params.append('PropertyOne', oc.PropertyOne);
    params.append('Id', 7);
    params.append('OcRef', 'ref 7');
    params.append('PropertyOne', 'prop 7');
    return axios({
      method: 'post',
      url: 'http://localhost:54188/api/oc',
      data: params,
      headers: {
        'Content-Type': 'application/json'
      }
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
