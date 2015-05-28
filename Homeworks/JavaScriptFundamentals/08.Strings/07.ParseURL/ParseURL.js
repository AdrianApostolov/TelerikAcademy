 /*
  Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
  Return the elements in a JSON object.
  Example:

  URL:
  http://telerikacademy.com/Courses/Courses/Details/239

  result:
  protocol: http
  server: telerikacademy.com
  resource: /Courses/Courses/Details/239
 */

 var jsConsole,
     url = 'http://telerikacademy.com/Courses/Courses/Details/239';


 function parseURL(url) {
     var protocol = '',
         server = '',
         resource = '';

     protocol = url.substr(0, url.indexOf("://"));
     url = url.substr(url.indexOf("://") + 3);
     server = url.substr(0, url.indexOf("/"));
     resource = url.substr(url.indexOf("/"));

     console.log('protocol: ' + protocol + "\n" + 'server: ' + server + "\n" + 'resource: ' + resource);
     jsConsole.writeLine('protocol: ' + protocol);
     jsConsole.writeLine('server: ' + server);
     jsConsole.writeLine('resource: ' + resource);

 }


 parseURL(url);