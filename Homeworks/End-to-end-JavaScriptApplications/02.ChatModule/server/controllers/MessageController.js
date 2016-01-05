var Message = require('mongoose').model('Message');

module.exports = {
    sendMessage: function (messageData) {
        var newMessage = new Message({
            from: messageData.from,
            to: messageData.to,
            text: messageData.text,
            createdOn: messageData.createdOn
        });

        newMessage.save(function (err, message) {
            if (err) {
                console.log(err);
            }
        })
    },
    getAllMessages: function (messageData, callback) {

        Message.find([{from: messageData.with, to: messageData.and},
                     {from: messageData.and, to: messageData.with}])
            .exec(function (err, result) {
                if (err) {
                    console.log(err);
                    return;
                }
                callback(result);
            });

    }
};