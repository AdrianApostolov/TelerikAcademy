var UserController,
    MessageController;

var Development_Connection_String = 'localhost:27017/ChatSystem';

module.exports = {
    init: function () {
        require('../config/mongoose')(Development_Connection_String);
        UserController = require('../controllers/UserController');
        MessageController = require('../controllers/MessageController');
    },
    registerUser: function (user) {
        UserController.registerUser(user);
    },
    sendMessage: function (messageData) {
        MessageController.sendMessage(messageData);
    },
    getMessages: function (messageData) {
      MessageController.getAllMessages(messageData, function (messages) {
          console.log(messages.join('\n\n'));
      });
    }
};