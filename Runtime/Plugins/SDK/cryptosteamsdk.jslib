mergeInto(LibraryManager.library, {
  
  
  getConfig: function() {
    var str = JSON.stringify(window.CryptoSteamSDK.getConfig().config);
    
    var bufferSize = lengthBytesUTF8(str) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(str, buffer, bufferSize);
    return buffer;
  },
  
  createReceipt: function(number, amount) {
    var str = window.CryptoSteamSDK.createReceipt(number, amount);
    
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
  
  // Emu methods
  isAdRunning: function() {
     return window.CryptoSteamEmuSDK.isAdRunning();
  },
  emuRequestAd: function() {
     return window.CryptoSteamEmuSDK.requestAd();
  },
  
  // New methods 
  trackGameTimeTick: function() {
    return window.CryptoSteamSDK.trackGameTimeTick();
  },
    
  getBalance: function(cb) {
    window.CryptoSteamSDK.getBalance().then(response => {
       var str = response.toString()
       
       var bufferSize = lengthBytesUTF8(str) + 1;
       var buffer = _malloc(bufferSize);
       stringToUTF8(str, buffer, bufferSize);
       
       dynCall_vi(cb, buffer);
    });
  },
  
    
});