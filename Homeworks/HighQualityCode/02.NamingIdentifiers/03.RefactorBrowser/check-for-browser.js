function onButtonClick(event, arguments) {
    var currentWindow = window,
        browser = currentWindow.navigator.appCodeName,
        isMozilla = (browser == "Mozilla");

    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}