export const createOc = oc => {
  return (dispatch, getState, { getFirebase, getFirestore }) => {
    //async call to db
    const firestore = getFirestore();
    const profile = getState().firebase.profile;
    const authorId = getState().firebase.auth.uid;
    firestore
      .collection('ocs')
      .add({
        ...oc,
        conseillerFirstName: profile.firstName,
        conseillerLastName: profile.lastName,
        authorId: authorId,
        createdAt: new Date()
      })
      .then(() => dispatch({ type: 'CREATE_OC', oc }))
      .catch(er => dispatch({ type: 'CREATE_OC_ERROR', er }));
  };
};
