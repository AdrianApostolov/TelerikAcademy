/*
 Write an expression that checks if given print (x, y)
 is within a circle K(O, 5).
 */

var jsConsole;
var button = document.getElementById('check');
var radius = 5;

button.addEventListener('click', function(){
    checkPointCircle(radius);
});

function checkPointCircle(radius){
    var x = jsConsole.readFloat("#x");
    var y = jsConsole.readFloat("#y");

    var isInCircle = Math.sqrt((x * x + y * y)) <= radius;

    jsConsole.writeLine('Is point in circle: ' + isInCircle);

    console.log('Is point in circle: ' + isInCircle);
}

