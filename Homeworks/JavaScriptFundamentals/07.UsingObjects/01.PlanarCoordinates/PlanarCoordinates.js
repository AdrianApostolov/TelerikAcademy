/*
 Write functions for working with shapes in standard Planar coordinate system.
 Points are represented by coordinates P(X, Y)
 Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
 Calculate the distance between two points.
 Check if three segment lines can form a triangle.
 */

var jsConsole;

function Point(x, y) {

    return {
        coordinatesX: x,
        coordinatesY: y,
        toString: function () {
            return '(' + this.coordinatesX + ', ' + this.coordinatesY + ')';
        }
    }
}

function Line(firstPoint, secondPoint) {
    return {
        startPoint: firstPoint,
        endPoint: secondPoint,
        toString: function () {
            return '((' + this.startPoint.coordinatesX + ', ' + this.startPoint.coordinatesY + '), ' +
                '' + '' + '(' + this.endPoint.coordinatesX + ', ' + this.endPoint.coordinatesY + '))';
        }
    }
}


function calculateDistance(startPoint, endPoint) {
    return Math.sqrt(Math.pow(startPoint.coordinatesX - endPoint.coordinatesX, 2)
        + Math.pow(startPoint.coordinatesY - endPoint.coordinatesY, 2));
}

function canFormTriangle(pointOne, pointTwo, pointTree) {
    var lineFirst = calculateDistance(pointOne, pointTwo);
    var lineSecond = calculateDistance(pointOne, pointTree);
    var lineThird = calculateDistance(pointTwo, pointTree);

    return lineFirst < lineSecond + lineThird &&
        lineSecond < lineFirst + lineThird &&
        lineThird < lineFirst + lineSecond;
}

var firstPoint = new Point(0, 0);
var secondPoint = new Point(5, 0);
var thirdPoint = new Point(1, 8, 2, 4);

jsConsole.writeLine('First point: ' + firstPoint);
jsConsole.writeLine('Second point: ' + secondPoint);
jsConsole.writeLine('Third point: ' + thirdPoint);

console.log('First point: ' + firstPoint + '\n' + 'Second point: ' + secondPoint +
    '\n' + 'Third point: ' + thirdPoint);

var firstLine = new Line(firstPoint, secondPoint);
var secondLine = new Line(firstPoint, thirdPoint);
var thirdLine = new Line(secondPoint, thirdPoint);

jsConsole.writeLine();
jsConsole.writeLine('First line: ' + firstLine);
jsConsole.writeLine('Second line: ' + secondLine);
jsConsole.writeLine('Third line: ' + thirdLine);

console.log('First line: ' + firstLine + '\n' + 'Second line: ' + secondLine +
    '\n' + 'Third line: ' + thirdLine);


jsConsole.writeLine();
jsConsole.writeLine('Can the segment lines form triangle: ' +
    canFormTriangle(firstPoint, secondPoint, thirdPoint));

console.log('Can the segment lines form triangle: ' +
    canFormTriangle(firstPoint, secondPoint, thirdPoint));