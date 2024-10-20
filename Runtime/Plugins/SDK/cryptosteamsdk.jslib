mergeInto(LibraryManager.library, {
  
  
  getConfig: function() {
    var str = JSON.stringify(window.CryptoSteamSDK.getConfig().config);
    
    var bufferSize = lengthBytesUTF8(str) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(str, buffer, bufferSize);
    return buffer;
  },
  
  createReceipt: function() {
    var str = window.CryptoSteamSDK.createReceipt();
    
    var bufferSize = lengthBytesUTF8(str) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(str, buffer, bufferSize);
    return buffer;
  },
  
  isAdEnabled: function(cb) {
    window.CryptoSteamSDK.isAdEnabled().then(response => {
        dynCall_vi(cb, response);
    });
  },
  
  getProfile: function(cb) {
  
    window.CryptoSteamSDK.getProfile().then(response => {
        
        var str = JSON.stringify(response)
        
        var bufferSize = lengthBytesUTF8(str) + 1;
        var buffer = _malloc(bufferSize);
        stringToUTF8(str, buffer, bufferSize);
        
        dynCall_vi(cb, buffer);
    });
    
  },
  
  getVersion: function() {
    var str = window.CryptoSteamSDK.getVersion();
    
    var bufferSize = lengthBytesUTF8(str) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(str, buffer, bufferSize);
    return buffer;
  },
  
   isAdRunning: function() {
      return window.CryptoSteamEmuSDK.isAdRunning();
   },
   
   runAd: function() {
     return window.CryptoSteamEmuSDK.runAd();
   },
    
});