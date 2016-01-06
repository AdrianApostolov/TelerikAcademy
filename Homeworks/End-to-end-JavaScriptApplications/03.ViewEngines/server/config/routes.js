var path = require('path');
var model = {
    nav: [{
        url: '/home',
        title: 'Home'
    }, {
        url: '/phones',
        title: 'Phones'
    }, {
        url: '/tablets',
        title: 'Tablets'
    }, {
        url: '/wearables',
        title: 'Wearables'
    }]
};
module.exports = function (app) {
    app.get('/home', function(req, res) {
        res.render('index', {nav : model});
    });

    app.get('/favicon.ico', function (req, res) {
        res.sendFile(path.resolve(__dirname + '/../../favicon.ico'))
    });

    app.get('/:partialName', function (req, res) {
        res.render('../../server/views/includes/' + req.params.partialName)
    });

    app.get('*', function(req, res) {
        res.render('index');
    });
};