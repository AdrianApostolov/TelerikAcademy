function solve(){
  return function(){
    $.fn.listview = function(data){
      var $this = $(this),
          templateId = $this.attr('data-template'),
          templateHtml = $('#' + templateId).html(),
          template = handlebars.compile(templateHtml);

      for (var i = 0, len = data.length; i < len; i+=1) {
          $this.append(template(data[i]));
      }

      return this;
    };
  };
}

module.exports = solve;