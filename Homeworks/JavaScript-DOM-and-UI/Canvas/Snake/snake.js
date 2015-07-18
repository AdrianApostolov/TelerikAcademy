var canvas = document.getElementById("the-canvas"),
    ctx = canvas.getContext("2d"),
    snake,
    cellSize = 10,
    direction,
    score;


function init() {
    direction = 'right';
    createSnake();
    createFood();
    if (typeof gameLoop !== 'undefined') {
        clearInterval(gameLoop);
    }
    gameLoop = setInterval(paint, 60);
    score = 0;
}

init();

function createSnake() {
    var snakeLength = 5;
    snake = [];

    for (var i = snakeLength - 1; i >= 0; i -= 1) {
        snake.push({x: i, y: 0});
    }
}

function createFood() {
    food = {
        x: Math.round(Math.random() * (canvas.width - cellSize) / cellSize),
        y: Math.round(Math.random() * (canvas.height - cellSize) / cellSize)
    }
}

function paint() {
    ctx.clearRect(0, 0, canvas.width, canvas.height);
    var snakeHeadX = snake[0].x;
    var snakeHeadY = snake[0].y;

    if (direction == 'right') {
        snakeHeadX++
    } else if (direction == 'left') {
        snakeHeadX--
    } else if (direction == 'up') {
        snakeHeadY--
    } else if (direction == 'down') {
        snakeHeadY++
    }

    if (snakeHeadX === -1 || snakeHeadX === canvas.width / cellSize ||
        snakeHeadY === -1 || snakeHeadY === canvas.height / cellSize ||
        checkCollision(snakeHeadX, snakeHeadY, snake)) {
        init();
        return;
    }

    if(snakeHeadX === food.x && snakeHeadY === food.y){
        var snakeTail = {x: snakeHeadX, y: snakeHeadY};
        score += 10;
        createFood()
    }else {
        snakeTail = snake.pop();
        snakeTail.x = snakeHeadX;
        snakeTail.y = snakeHeadY;
    }

    snake.unshift(snakeTail);

    for (var i = 0, len = snake.length; i < len; i += 1) {

        var currentElement = snake[i];
        paintCell(currentElement.x, currentElement.y, 'yellowgreen', 'purple');
    }

    paintCell(food.x, food.y, 'yellow', 'purple' );

    var scoreText = document.getElementById('score');
    scoreText.innerHTML = 'Score: ' + score;
}

function paintCell(x, y, fillStyle, strokoStyle) {

    ctx.fillStyle = fillStyle;
    ctx.fillRect(x * cellSize, y * cellSize, cellSize, cellSize);
    ctx.strokeStyle = strokoStyle;
    ctx.strokeRect(x * cellSize, y * cellSize, cellSize, cellSize);
}

function checkCollision(x, y, array) {

    for (var i = 0, len = array.length; i < len; i+=1) {
        if(array[i].x === x && array[i].y === y){
            return true
        }
    }

    return false;
}

document.onkeydown = function (event) {

    var key = event.which;
    if (key === 37) {
        if (direction !== 'right') {
            direction = 'left';
        }
    } else if (key === 38) {
        if (direction !== 'down') {
            direction = 'up';
        }
    } else if (key === 39) {
        if (direction !== 'left') {
            direction = 'right';
        }
    } else if (key === 40) {
        if (direction !== 'up') {
            direction = 'down';
        }
    }
};