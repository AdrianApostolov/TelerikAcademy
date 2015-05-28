/*
 You are given a text. Write a function that changes the text in all regions:

 <upcase>text</upcase> to uppercase.
 <lowcase>text</lowcase> to lowercase
 <mixcase>text</mixcase> to mix casing(random)
 Example: We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>.
 We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.

 The expected result:
 We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.

 Note: Regions can be nested.
*/

var jsConsole,
    text = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>.' +
    'We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.',
    result = '';

for (var i = 0; i < text.length; i += 1) {

    if (text[i] == '<' && text[i + 1] == 'u') {
        i += 8;
        while (text[i] != '<' ) {
            result += text[i].toUpperCase();
            i += 1;
        }
        if(text[i + 1] == '/') {
            i += 8;
        }
        else {
            i--;
        }
    }
    else if(text[i] == '<' && text[i + 1] == 'm'){
        i += 9;
        while (text[i] != '<'){
            if(Math.random() < 0.5){
                result += text[i].toUpperCase();
                i += 1;
            }
            else{
                result += text[i].toLowerCase();
                i += 1;
            }
        }
        if(text[i + 1] == '/') {
            i += 9;
        }else {
            i--;
        }
    }
    else if (text[i] == '<' && text[i + 1] == 'l') {
        i += 9;
        while (text[i] != '<') {
            result += text[i].toLowerCase();
            i += 1;
        }
        if(text[i + 1] == '/'){
            i += 9;
        } else {
            i--;
        }
    }

    else {
        result += text[i];
    }
}


jsConsole.writeLine(text);
jsConsole.writeLine(result);

console.log(text);
console.log(result);