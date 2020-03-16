export const createOc = oc => {
  return (dispatch, getState, { getFirebase, getFirestore }) => {
    //async call to db
    dispatch({ type: 'CREATE_OC', oc });
  };
};
