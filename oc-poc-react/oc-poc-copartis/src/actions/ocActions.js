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
  return (dispatch, getState) => {
    axios
      .get('http://localhost:54188/api/oc')
      .then(response => {
        dispatch({
          type: 'GET_ALL_OCS',
          ocs: response.data
        });
      })
      .catch(er => console.log(er));
  };
};

export const deleteOc = id => {
  return (dispatch, getState) => {
    axios
      .delete('http://localhost:54188/api/oc/', { params: { id: id } })
      .then(response => {
        dispatch({
          type: 'DELETE_OC',
          oc: response.data
        });
      });
  };
};

export const getOcById = id => {
  return (dispatch, getState) => {
    axios
      .get('http://localhost:54188/api/oc/' + id)
      .then(response => {
        dispatch({
          type: 'GET_OC_BY_ID',
          oc: response.data
        });
      })
      .catch(er => console.log(er));
  };
};
