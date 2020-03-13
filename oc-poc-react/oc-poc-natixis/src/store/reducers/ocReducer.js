const initState = {
  ocs: [
    { id: 1, ocRef: 'ref 1', modeSoummision: 'Electronic' },
    { id: 2, ocRef: 'ref 2', modeSoummision: 'Semi Electronic' },
    { id: 3, ocRef: 'ref 3', modeSoummision: 'Manual' }
  ]
};

const ocReducer = (state = initState, action) => {
  return state;
};

export default ocReducer;
