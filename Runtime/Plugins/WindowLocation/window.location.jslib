mergeInto(LibraryManager.library, {

  SetLocation: function(url) {
    var urlStr = UTF8ToString(url);
    window.location = urlStr;
  },
  
  SetLocationWindow: function(url) {
    var urlStr = UTF8ToString(url);
    window.open(urlStr, '_blank');
  },
  
  SetLocationRelative: function(url) {
      var urlStr = UTF8ToString(url);
      window.location = window.location.origin + urlStr;
  },
  
  SetLocationRelativeWindow: function(url) {
      var urlStr = UTF8ToString(url);
      window.open(window.location.origin + urlStr, '_blank');
  },
    
  WindowReload: function(url) {
    window.location.reload();
  },

  LocationHref: function () {
    var returnStr = window.location.href;
    var bufferSize = lengthBytesUTF8(returnStr) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(returnStr, buffer, bufferSize);
    return buffer;
  },
  
  LocationHash: function () {
      var returnStr = window.location.hash;
      var bufferSize = lengthBytesUTF8(returnStr) + 1;
      var buffer = _malloc(bufferSize);
      stringToUTF8(returnStr, buffer, bufferSize);
      return buffer;
  },
    
  LocationHost: function () {
      var returnStr = window.location.host;
      var bufferSize = lengthBytesUTF8(returnStr) + 1;
      var buffer = _malloc(bufferSize);
      stringToUTF8(returnStr, buffer, bufferSize);
      return buffer;
  },
    
});