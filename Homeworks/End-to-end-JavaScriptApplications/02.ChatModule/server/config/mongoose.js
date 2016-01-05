var mongoose = require('mongoose'),
    User = require('../models/User'),
    Message = require('../models/Message');

module.exports = function (connectionString) {
    mongoose.connect(connectionString);

    var db = mongoose.connection;

    db.once('open', function (error) {
        if (error) {
            console.log(error);
            return;
        }

        console.log('MongoDB database up and running...');
    });

    db.on('error', function (error) {
        console.log(error);
    });
};