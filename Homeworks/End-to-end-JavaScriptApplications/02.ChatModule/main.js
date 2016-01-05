var chatDb = require('./server/controllers/ChatDb');

chatDb.init();

//chatDb.registerUser({ username: 'DonchoMinkov', password: '123456q' });
//chatDb.registerUser({ username: 'NikolayKostov', password: '123456q' });
//
//chatDb.sendMessage({
//    from: 'DonchoMinkov',
//    to: 'NikolayKostov',
//    text: 'Hey, Niki!'
//});
//
//chatDb.sendMessage({
//    from: 'NikolayKostov',
//    to: 'DonchoMinkov',
//    text: 'Hey, Doncho!'
//});
//
//chatDb.sendMessage({
//    from: 'NikolayKostov',
//    to: 'DonchoMinkov',
//    text: 'How are you today?'
//});
//
//chatDb.sendMessage({
//    from: 'DonchoMinkov',
//    to: 'NikolayKostov',
//    text: 'I\'m fine! You?'
//});

setTimeout(function () {
    chatDb.getMessages({
        with: 'DonchoMinkov',
        and: 'NikolayKostov'
    });
}, 1500);