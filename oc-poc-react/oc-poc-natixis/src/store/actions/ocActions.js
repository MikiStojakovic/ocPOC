export const createOc = oc => {
  return (dispatch, getState, { getFirebase, getFirestore }) => {
    //async call to db
    const firestore = getFirestore();
    firestore
      .collection('ocs')
      .add({
        ...oc,
        conseillerFirstName: 'Kunjo',
        conseillerLastName: 'Polumenta'
      })
      .then(() => dispatch({ type: 'CREATE_OC', oc }))
      .catch(er => dispatch({ type: 'CREATE_OC_ERROR', er }));
  };
};
