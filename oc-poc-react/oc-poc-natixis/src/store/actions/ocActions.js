export const createOc = oc => {
  return (dispatch, getState) => {
    //async call to db
    dispatch({ type: 'CREATE_OC', oc });
  };
};
