var User = require('mongoose').model('User');

module.exports = {
    registerUser: function (user) {
        var newUser = new User({
            username: user.username,
            password: user.password
        });

        newUser.save(function (err, user) {
            if (err) {
                console.log(err);
            }
        })
    }
};