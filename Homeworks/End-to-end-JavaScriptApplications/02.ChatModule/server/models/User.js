var mongoose = require('mongoose');
var uniqueValidator = require('mongoose-unique-validator');

var userSchema = mongoose.Schema({
    username: {type: String, required: true, unique: true},
    password: {type: String}
});

userSchema.plugin(uniqueValidator);

mongoose.model('User', userSchema);