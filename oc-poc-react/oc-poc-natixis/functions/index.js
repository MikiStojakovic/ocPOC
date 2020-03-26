const functions = require('firebase-functions');
const admin = require('firebase-admin');
admin.initializeApp(functions.config().firebase);

exports.helloWorld = functions.https.onRequest((request, response) => {
  response.send('Hello from Firebase!');
});

const createNotification = nofitication => {
  return admin
    .firestore()
    .collection('notifications')
    .add(nofitication)
    .then(doc => console.log('notification added', doc));
};

exports.ocCreated = functions.firestore.document('ocs/{ocId}').onCreate(doc => {
  const oc = doc.data();
  const nofitication = {
    content: 'Added new oc',
    user: `${oc.conseillerFirstName} ${oc.conseillerLastName}`,
    time: admin.firestore.FieldValue.serverTimestamp()
  };

  return createNotification(nofitication);
});

exports.userJoined = functions.auth.user().onCreate(user => {
  return admin
    .firestore()
    .collection('users')
    .doc(user.uid)
    .get()
    .then(doc => {
      const newUser = doc.data;
      const notification = {
        content: 'Joined user',
        user: `${newUser.firstName} ${newUser.lastName}`,
        time: admin.firestore.FieldValue.serverTimestamp()
      };

      return createNotification(notification);
    });
});
